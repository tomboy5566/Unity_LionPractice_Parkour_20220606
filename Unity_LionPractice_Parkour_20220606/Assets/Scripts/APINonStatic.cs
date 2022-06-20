using UnityEngine;

namespace KuanLun
{
    /// <summary>
    /// �D�R�AAPI�ݭn�����(�C������)
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject player;
        [SerializeField]
        private Transform finalpoint;

        private void Start()
        {
            print($"���a�Ұʪ��A��: {player.activeInHierarchy}");
            print($"���a�Ҧb�ϼh��: {player.layer}");
            
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


