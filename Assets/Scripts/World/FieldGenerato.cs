using UnityEngine;
public class WorldGenerator : MonoBehaviour
{
    [SerializeField] GameObject groundPrefab;
    [SerializeField] GameObject playerPrefub;
    [SerializeField] EnemySpawner _enemySpawner;
    [SerializeField] int width, height;
    private Vector3 _groundSize;
    private float curvedTexturX;
    private float curvedTextureZ;
    private void Start()
    {
        
       
        _groundSize = groundPrefab.GetComponent<Renderer>().bounds.size;
        curvedTexturX = 3;
        curvedTextureZ = 2;
        GenerateField(width, height);
        GeneratePlayer(width, height);
        Destroy(this);
    }
    private void GenerateField(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                var newPosition = new Vector3(j * (_groundSize.x-curvedTexturX),0, i * (_groundSize.z-curvedTextureZ));
                Instantiate(groundPrefab, newPosition, Quaternion.identity, transform);
            }
        }
    }
    private void GeneratePlayer(int width, int height)
    {
        var widthHalf = width / 2;
        var heighthHalf = height / 2;
        var newPosition = new Vector3(widthHalf * (_groundSize.x-curvedTexturX),0, heighthHalf * (_groundSize.z-curvedTextureZ));
       GameObject player = Instantiate(playerPrefub, newPosition,Quaternion.identity);
       Camera.main.GetComponent<CameraController>().SetPlayer(player.transform);
       _enemySpawner.Init(player.transform);
    }
}