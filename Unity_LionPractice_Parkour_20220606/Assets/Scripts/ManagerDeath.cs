using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KuanLun
{
    public class ManagerDeath : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nametarget = "玩家";
        [SerializeField, Header("結束控制器")]
        private ManagerGameFinalChoose finalChoose;
        [SerializeField, Header("攝影機控制器")]
        private GameObject goCamera;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nametarget))
            {
                finalChoose.gamefinalstring = "失☆敗";
                finalChoose.enabled = true;
                goCamera.SetActive(false);
            }
        }
    }
}

