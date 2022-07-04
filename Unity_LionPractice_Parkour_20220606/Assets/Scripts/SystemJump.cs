using UnityEngine;

namespace KuanLun
{
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("�ˬd�a����Ĳ����j�p")]
        private Vector3 v3groundchecksize = Vector3.one;
        [SerializeField, Header("�ˬd�a���첾")]
        private Vector3 v3groundcheckOffset;
        [SerializeField, Header("�a���ˬd�C��")]
        private Color groundcheckcolor = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�ϼh")]
        private LayerMask layergroundcheck;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        #endregion
        #region �\��
        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        private void JumpForce()
        {
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }
        private void GroundCheck()
        {
            Collider2D hitground = Physics2D.OverlapBox(transform.position + v3groundcheckOffset, v3groundchecksize, 0, layergroundcheck);
            //print("�ثe�I������: " + hitground.name);
            isGround = hitground;
        }
        #endregion
        #region �ƥ�
        //ø�s�ˬd�a����Ĳ�����U���(�C���������)
        private void OnDrawGizmos()
        {
            Gizmos.color = groundcheckcolor;
            Gizmos.DrawCube(transform.position + v3groundcheckOffset, v3groundchecksize);
        }
        private void Update()
        {
            Jump();
            GroundCheck();
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

