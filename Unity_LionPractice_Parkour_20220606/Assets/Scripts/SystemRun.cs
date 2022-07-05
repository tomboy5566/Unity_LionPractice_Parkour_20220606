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
        private Animator ani;
        private Rigidbody2D rig;
        #endregion
        #region �\��:��{�t�Υ\�઺��k
        /// <summary>
        /// �]�_�Ӱ�!�V��!
        /// </summary>
        private void Run()
        {
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        #endregion
        #region �ƥ�:�{���J�f

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            //print("2�~2�~");
        }

        private void Update()
        {
            //print("���@�Ufps");
            Run();
            
        }
        #endregion
        private void OnEnable()
        {
            
        }
        private void OnDisable()
        {
            rig.velocity = Vector2.zero;
        }

    }
}


