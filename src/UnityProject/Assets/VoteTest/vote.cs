
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

namespace votetest
{
    public class vote : UdonSharpBehaviour
    {

        public GameObject Vote;
        public int counter = 0;

        public override void Interact()
        {
            counter++;
            Vote.GetComponent<Text>().text = counter.ToString();
        }
    }
}
