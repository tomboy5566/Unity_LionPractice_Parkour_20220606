using UnityEngine;

namespace KuanLun
{
    /// <summary>
    /// 靜態API使用方法
    /// </summary>

    public class APIStatic : MonoBehaviour
    {

        #region 上課
        //private void Start()
        //{
        //print($"隨機值: {Random.value}");
        //print($"PI值: {Mathf.PI}");
        //print("無限: "+Mathf.Infinity);

        //Cursor.visible = false;
        //Physics2D.gravity = new Vector2(0, -29.4f);
        //Time.timeScale = 1f;

        //float floatrange = Random.Range(10.0f, 100.0f);
        //print($"浮點數隨機: {floatrange}");
        //int intrange = Random.Range(1, 5);
        //print($"整數隨機: {intrange}");
        //}
        #endregion

        #region 練習

        private void Start()
        {
            // 計算camera數量
            print($"Camera數量: {Camera.allCamerasCount}");
            // 顯示平台
            print($"現在平台為: {Application.platform}");
            // 3D物理睡眠臨界值設定為10
            Physics.sleepThreshold = 10;
            // 時間大小設定為 0.5 (慢動作)
            Time.timeScale = 0.5f;
            //對 9.999 去小數點 (不限制去除方式)
            print($"9.999去小數點為: {Mathf.Floor(9.999f)}");
            //取得兩點的距離
            print($"(1,1,1)和(22,22,22)的距離為: {Vector3.Distance(new Vector3 (1,1,1), new Vector3(22,22,22))}");
            //開啟連結
            Application.OpenURL("https://unity.com/");
        }

        private void Update()
        {
            // 是否輸入任意鍵
            print($"現在是否輸入任意鍵: {Input.anyKey}");
            //是否按下按鍵 (指定為空白鍵)
            print($"現在是否按下空白鍵: {Input.GetKeyDown("space")}");
            // 遊戲經過時間
            print($"現在遊戲時間: {Time.realtimeSinceStartup}");
            
        }

        #endregion
    }
}

