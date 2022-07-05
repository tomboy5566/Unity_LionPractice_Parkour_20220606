using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KuanLun
{
    public class ManagerDeath : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nametarget = "���a";
        [SerializeField, Header("�������")]
        private ManagerGameFinalChoose finalChoose;
        [SerializeField, Header("��v�����")]
        private GameObject goCamera;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nametarget))
            {
                finalChoose.gamefinalstring = "������";
                finalChoose.enabled = true;
                goCamera.SetActive(false);
            }
        }
    }
}

