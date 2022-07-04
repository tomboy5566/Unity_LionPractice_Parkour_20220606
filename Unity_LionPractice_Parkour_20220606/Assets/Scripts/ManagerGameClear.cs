using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KuanLun
{
    public class ManagerGameClear : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "���a";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemrun;
        [SerializeField, Header("���D�t��")]
        private SystemJump systemjump;
        [SerializeField, Header("�������")]
        private ManagerGameFinalChoose finalchoose;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if (collision.name.Contains(nameTarget))
            {
                systemrun.enabled = false;
                systemjump.enabled = false;
                finalchoose.enabled = true;

                finalchoose.gamefinalstring = "���߹L��!!!";
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





