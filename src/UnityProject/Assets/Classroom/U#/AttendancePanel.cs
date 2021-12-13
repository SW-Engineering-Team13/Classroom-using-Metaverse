
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;
public class AttendancePanel : UdonSharpBehaviour
{
    public ClassroomData classData;
    public StudentData studentData; 
    private void Start() {
        int len = classData.initialLize() + 1;
        studentData.initialize();
        for (int i = 0; i < len; i++)
        {
            GameObject temp = this.gameObject.transform.GetChild(i).gameObject;
            Text temp2 = (Text)temp.GetComponentInChildren(typeof(Text));
            temp2.text = classData.studentidArr[i].ToString() +" " + studentData.getNameById(classData.studentidArr[i]);
        }
    }
}
