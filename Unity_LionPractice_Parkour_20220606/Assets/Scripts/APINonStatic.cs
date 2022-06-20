using UnityEngine;

namespace KuanLun
{
    /// <summary>
    /// 非靜態API需要控制物件(遊戲物件)
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject player;
        [SerializeField]
        private Transform finalpoint;

        private void Start()
        {
            print($"玩家啟動狀態為: {player.activeInHierarchy}");
            print($"玩家所在圖層為: {player.layer}");
            
            player.layer = 4;
            player.tag = "Player";

            player.SetActive(false);

            finalpoint.position = new Vector3(0, 5, 0);
            
        }
        private void Update()
        {
            finalpoint.Translate(3.5f, 0, 0);
            finalpoint.Rotate(0, 0, 0.5f);
        }
    }
}


