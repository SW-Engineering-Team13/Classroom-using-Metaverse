
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDK3.Components;
using VRC.SDK3.Components.Video;
using VRC.SDK3.Video.Components.Base;
using VRC.SDKBase;
using VRC.Udon.Common.Interfaces;
using VRC.Udon;

public class VideoController_Sharp : UdonSharpBehaviour
{

    private BaseVRCVideoPlayer videoPlayer;
    private int loadedVideoNumber;

    [UdonSynced] private VRCUrl syncedURL;
    [UdonSynced] private int currentVideoNumber;
    [UdonSynced] private float videoTime;
    [UdonSynced] private bool ownerPlaying = true;

    public AudioSource[] speakers;
    public Slider sliderVolume;
    public VRCUrlInputField URLField;
    public Text textOwner;
    public GameObject buttonPlay;
    public GameObject buttonPause;

    void Start()
    {
        videoPlayer = (BaseVRCVideoPlayer) GetComponent(typeof(BaseVRCVideoPlayer));
        textOwner.text = "Owner: " + Networking.GetOwner(gameObject).displayName;
    }

    public override void OnDeserialization()
    {
        if(loadedVideoNumber != currentVideoNumber)
        {
            loadedVideoNumber = currentVideoNumber;
            if(syncedURL.Get() != "" && syncedURL.Get() != null)
            {
                LoadURL();
            }
        }

        if (!Networking.IsOwner(gameObject))
        {
            if(ownerPlaying != videoPlayer.IsPlaying)
            {
                if(ownerPlaying)
                {
                    videoPlayer.Play();
                    buttonPause.SetActive(true);
                    buttonPlay.SetActive(false);
                }
                else
                {
                    videoPlayer.Pause();
                    videoPlayer.SetTime(videoTime);
                    buttonPause.SetActive(false);
                    buttonPlay.SetActive(true);
                }
            }
        }
    }

    public override void OnOwnershipTransferred()
    {
        textOwner.text = "Owner: " + Networking.GetOwner(gameObject).displayName;
    }

    private void Update()
    {
        if (videoPlayer.IsPlaying)
        {
            if (Networking.IsOwner(gameObject))
            {
                videoTime = videoPlayer.GetTime();
            }
            else
            {
                if(Mathf.Abs(videoTime - videoPlayer.GetTime()) > 2)
                {
                    videoPlayer.SetTime(videoTime);
                }
            }
        }
        
    }

    public void SetOwner()
    {
        if(!Networking.IsOwner(gameObject))
        {
            Networking.SetOwner(Networking.LocalPlayer, gameObject);
        }
    }

    public void PlayPause()
    {
        if (Networking.IsOwner(gameObject))
        {
            if (videoPlayer.IsPlaying)
            {
                videoPlayer.Pause();
                buttonPause.SetActive(false);
                buttonPlay.SetActive(true);
                ownerPlaying = false;
            }
            else
            {
                videoPlayer.Play();
                buttonPause.SetActive(true);
                buttonPlay.SetActive(false);
                ownerPlaying = true;
            }
        }
    }

    public void SetVolume()
    {
        for(int i = 0; i < speakers.Length; i ++)
        {
            speakers[i].volume = sliderVolume.value;
        }
    }

    public void SetURL()
    {
        if (!Networking.IsOwner(gameObject)) return;

        syncedURL = URLField.GetUrl();
        currentVideoNumber += 1;
        loadedVideoNumber = currentVideoNumber;
        LoadURL();
    }

    public void LoadURL()
    {
        videoPlayer.Stop();
        videoPlayer.LoadURL(syncedURL);
    }

    public override void OnVideoReady()
    {
        videoPlayer.Play();

        if (Networking.IsOwner(gameObject))
        {
            buttonPause.SetActive(true);
            buttonPlay.SetActive(false);
            ownerPlaying = true;
        }
    }

    public override void OnVideoError(VideoError videoError)
    {
        if (videoError == VideoError.RateLimited &&
            videoError == VideoError.PlayerError)
        {
            if (Networking.IsOwner(gameObject))
            {
                LoadURL();
            }
            else
            {
                loadedVideoNumber -= 1;
            }
        }
    }
}
