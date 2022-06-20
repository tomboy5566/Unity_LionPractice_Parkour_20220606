using UnityEngine;
namespace KuanLun
{
    /// <summary>
    /// 跑步功能+跳躍功能
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料:系統所需資料
        [SerializeField, Header("角色跑步速度"), Tooltip("控制角色跑步速度"), Range(0,100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("角色跳躍高度"), Tooltip("控制角色跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion
        #region 功能:實現系統功能的方法

        #endregion
        #region 事件:程式入口

        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void Start()
        {
            print("2ㄏ2ㄏ");
        }

        private void Update()
        {
            //print("測一下fps");
        }
        #endregion


    }
}


