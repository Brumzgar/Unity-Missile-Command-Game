using UnityEngine;

public class EnemyMissileManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyMissileListExample;
    private GameObject[] enemyMissileList;

    public static GameObject[] enemyTargetList;

    private float enemyMissileSpeedFloat;

    private void Start()
    {
        UpdateEnemyTargetList();
        enemyMissileSpeedFloat = PlayerPrefs.GetFloat("enemyMissilesSpeed");
        PlayerPrefs.SetFloat("enemyMissilesSpeed", 0.25f + enemyMissileSpeedFloat);
    }

    public void EnemyMissilesWave()
    {
        print(PlayerPrefs.GetFloat("enemyMissilesSpeed") + " = PlayerPrefs.GetFloat(enemyMissilesSpeed)");

        UpdateEnemyTargetList();

        CreateEnemyMissileList();
    }
    private void CreateEnemyMissileList()
    {
        enemyMissileList = new GameObject[enemyMissileListExample.Length];

        for (int i = 0; i < enemyMissileListExample.Length; i++)
        {
            enemyMissileList[i] = Instantiate(enemyMissileListExample[i], transform) as GameObject;
        }
    }

    public static void UpdateEnemyTargetList()
    {
        enemyTargetList = GameObject.FindGameObjectsWithTag("Target");
    }
}
