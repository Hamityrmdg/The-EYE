using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Respawn : MonoBehaviour
{
    public GameObject spawnPoint;
    
    int sahne_id;
    public GameObject player;
    [SerializeField] private Image[] hearts;
    public int playerHealth;
    [SerializeField] public ball3 _speed;
    private void OnTriggerEnter(Collider other)
    {
        
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)
            {
                if (other.tag == "Respawn")
                {
                    this.transform.position = spawnPoint.transform.position;
                    //_speed.speed = 0;
                }
            }
            else { SceneManager.LoadScene(sahne_id); }
                    
        }
    }
}
