//using UdonSharp;
//using UnityEngine.Video;
//using UnityEngine.UI;
//using UnityEngine;
//using VRC.Udon.Common.Interfaces;
//using VRC.SDKBase;
//using VRC.Udon;

//public class MP4Player : UdonSharpBehaviour
//{
//    [UdonSynced]
//    public string url;
//    int delay1;
//    int delay2;
//    int delay3;
//    int ownerDelay;
//    public InputField input;
//    public InputField videoURL;
//    public Animator newVideo;
//    public Animator pauseVideo;
//    public Animator resumeVideo;
//    int mode;
//    public void Start()
//    {
//        delay1 = 0;
//        delay2 = 0;
//        delay3 = 0;
//        mode = 1;
//    }
//    public void NewVideo()
//    {
//        Networking.SetOwner(Networking.LocalPlayer, this.gameObject);
//        ownerDelay = 80;
//        mode = 1;
//    }
//    public void PauseVideo()
//    {
//        Networking.SetOwner(Networking.LocalPlayer, this.gameObject);
//        ownerDelay = 80;
//        mode = 2;
//    }
//    public void ResumeVideo()
//    {
//        Networking.SetOwner(Networking.LocalPlayer, this.gameObject);
//        ownerDelay = 80;
//        mode = 3;
//    }
//    public void SetDelay1Synced()
//    {
//        delay1 = 80;
//    }
//    public void SetDelay2Synced()
//    {
//        delay2 = 80;
//    }
//    public void SetDelay3Synced()
//    {
//        delay3 = 80;
//    }
//    public void Update()
//    {
//        if (ownerDelay > 0)
//        {
//            ownerDelay--;
//            if (ownerDelay == 0)
//            {
//                if (mode == 1)
//                {
//                    url = input.text;
//                    SendCustomNetworkEvent(NetworkEventTarget.All, "SetDelay1Synced");
//                }
//                else if (mode == 2)
//                {
//                    SendCustomNetworkEvent(NetworkEventTarget.All, "SetDelay2Synced");
//                }
//                else if (mode == 3)
//                {
//                    SendCustomNetworkEvent(NetworkEventTarget.All, "SetDelay3Synced");
//                }
//            }
//        }
//        if (delay1 > 0)
//        {
//            delay1--;
//            if (delay1 == 0)
//            {
//                videoURL.text = url;
//                newVideo.SetTrigger("trigger");
//            }
//        }
//        if (delay2 > 0)
//        {
//            delay2--;
//            if (delay2 == 0)
//            {
//                pauseVideo.SetTrigger("trigger");
//            }
//        }
//        if (delay3 > 0)
//        {
//            delay3--;
//            if (delay3 == 0)
//            {
//                resumeVideo.SetTrigger("trigger");
//            }
//        }
//    }
//}