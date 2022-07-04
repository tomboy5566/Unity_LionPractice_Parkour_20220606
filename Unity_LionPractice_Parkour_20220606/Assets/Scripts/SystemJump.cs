using UnityEngine;

namespace KuanLun
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("檢查地面接觸方塊大小")]
        private Vector3 v3groundchecksize = Vector3.one;
        [SerializeField, Header("檢查地面位移")]
        private Vector3 v3groundcheckOffset;
        [SerializeField, Header("地面檢查顏色")]
        private Color groundcheckcolor = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查圖層")]
        private LayerMask layergroundcheck;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        #endregion
        #region 功能
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
            //print("目前碰撞物件為: " + hitground.name);
            isGround = hitground;
        }
        #endregion
        #region 事件
        //繪製檢查地面接觸的輔助方塊(遊戲內不顯示)
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

