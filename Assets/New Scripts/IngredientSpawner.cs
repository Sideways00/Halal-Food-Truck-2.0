using UnityEngine;

public class IngredientSpawner : MonoBehaviour
{
    public GameObject ingredientPrefab;
    public Transform spawnPoint;

    public void SpawnIngredient()
    {
        if (ingredientPrefab == null || spawnPoint == null)
        {
            Debug.LogError("Missing ingredient prefab or spawn point!");
            return;
        }

        Instantiate(
            ingredientPrefab,
            spawnPoint.position,
            Quaternion.identity
        );
    }
}
