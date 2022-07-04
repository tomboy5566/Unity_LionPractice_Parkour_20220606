using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace KuanLun
{
    public class ManagerGameFinalChoose : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupfinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textfinal;
        public string gamefinalstring;

        private void Start()
        {
            InvokeRepeating("Fadein", 0, 0.2f);
            textfinal.text = gamefinalstring;
        }

        private void Fadein()
        {
            groupfinal.alpha += 0.1f;
            if (groupfinal.alpha >= 1f)
            {
                groupfinal.interactable = true;
                groupfinal.blocksRaycasts = true;

                CancelInvoke("Fadein");
            }
        }
        public void Quit()
        {
            Application.Quit();
            print("�u");
        }
        public void Reload()
        {
            SceneManager.LoadScene(0);
        }
    }
}

