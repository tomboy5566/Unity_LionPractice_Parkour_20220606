using UnityEngine;

namespace KuanLun
{
    /// <summary>
    /// �R�AAPI�ϥΤ�k
    /// </summary>

    public class APIStatic : MonoBehaviour
    {

        #region �W��
        //private void Start()
        //{
        //print($"�H����: {Random.value}");
        //print($"PI��: {Mathf.PI}");
        //print("�L��: "+Mathf.Infinity);

        //Cursor.visible = false;
        //Physics2D.gravity = new Vector2(0, -29.4f);
        //Time.timeScale = 1f;

        //float floatrange = Random.Range(10.0f, 100.0f);
        //print($"�B�I���H��: {floatrange}");
        //int intrange = Random.Range(1, 5);
        //print($"����H��: {intrange}");
        //}
        #endregion

        #region �m��

        private void Start()
        {
            // �p��camera�ƶq
            print($"Camera�ƶq: {Camera.allCamerasCount}");
            // ��ܥ��x
            print($"�{�b���x��: {Application.platform}");
            // 3D���z�ίv�{�ɭȳ]�w��10
            Physics.sleepThreshold = 10;
            // �ɶ��j�p�]�w�� 0.5 (�C�ʧ@)
            Time.timeScale = 0.5f;

        }

        private void Update()
        {
            // �O�_��J���N��
            print($"�{�b�O�_��J���N��: {Input.anyKey}");
            // �C���g�L�ɶ�
            print($"�{�b�C���ɶ�: {Time.realtimeSinceStartup}");
        }

        #endregion
    }
}

