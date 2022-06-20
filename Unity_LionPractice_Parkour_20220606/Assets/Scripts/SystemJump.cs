using UnityEngine;

namespace KuanLun
{
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion
        #region �\��
        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickJump = true;
            }
        }
        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }
        #endregion
        #region �ƥ�
        private void Update()
        {
            Jump();
        }
        private void FixedUpdate()
        {
            JumpForce();
        }
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        #endregion

    }
}

