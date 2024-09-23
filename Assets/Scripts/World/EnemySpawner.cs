using System.Collections;
using UnityEngine;
using Random = System.Random;
public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] public float delay;
    [SerializeField] public int min;
    [SerializeField] public int max;
    private Transform target; 
    public void Init(Transform target)
    {
       this.target = target;
        
    }
    public void StartWave(float waveCount)
    {
        StartCoroutine(Spawn(target,waveCount));
    }
    IEnumerator Spawn(Transform target,float waveCout)
    {
        Random random = new Random();
        for (int i = 0; i < waveCout; i++)
        {
            var x = random.Next((int)(target.position.x+min), (int)(target.position.x+max));
            var z = random.Next((int)(target.position.z+min), (int)(target.position.x+max));
            Vector3 newPosition = new Vector3(x, 0, z);
            var enemy = Instantiate(enemyPrefab,newPosition,Quaternion.identity,transform);
            enemy.GetComponent<Zombie>().Target = target;
            yield return new WaitForSeconds(delay);
        }
        
        
    }
}
