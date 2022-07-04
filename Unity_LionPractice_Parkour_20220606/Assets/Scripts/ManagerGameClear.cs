using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KuanLun
{
    public class ManagerGameClear : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "玩家";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemrun;
        [SerializeField, Header("跳躍系統")]
        private SystemJump systemjump;
        [SerializeField, Header("結束控制器")]
        private ManagerGameFinalChoose finalchoose;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if (collision.name.Contains(nameTarget))
            {
                systemrun.enabled = false;
                systemjump.enabled = false;
                finalchoose.enabled = true;

                finalchoose.gamefinalstring = "恭喜過關!!!";
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {

        }
        private void OnTriggerStay2D(Collider2D collision)
        {

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {

        }
        private void OnCollisionExit2D(Collision2D collision)
        {

        }
        private void OnCollisionStay2D(Collision2D collision)
        {

        }
    }
}





