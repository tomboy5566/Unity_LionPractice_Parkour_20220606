using UnityEngine;
namespace KuanLun
{
    /// <summary>
    /// �]�B�\��+���D�\��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�t�Ωһݸ��
        [SerializeField, Header("����]�B�t��"), Tooltip("�����]�B�t��"), Range(0,100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("������D����"), Tooltip("�������D����"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion
        #region �\��:��{�t�Υ\�઺��k

        #endregion
        #region �ƥ�:�{���J�f

        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void Start()
        {
            print("2�~2�~");
        }

        private void Update()
        {
            //print("���@�Ufps");
        }
        #endregion


    }
}


