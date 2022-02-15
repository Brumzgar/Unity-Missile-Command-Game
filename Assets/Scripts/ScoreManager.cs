using System.Collections;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Zmienic nazwe na SummaryManager ? 

    public static GameObject[] enemyMissilesList;

    private bool scoreManagerFlag;

    // [SerializeField]
    // private GameObject scoreText;

    // [SerializeField]
    // private GameObject highScoreText;

    public static void StartSummary()
    {
        print("StartSummary()");
        // StartCoroutine(UpdateEnemyMissilesList()); - zmienic na invoke repeating
        // InvokeRepeating("UpdatePath", 0f, .5f);
    }

    /*void Update()
    {
        if (GameStateManager.State == GameState.Summary && scoreManagerFlag == false)
        {
            scoreManagerFlag = true;
            StartCoroutine(UpdateEnemyMissilesList());
        }
    }*/

    IEnumerator UpdateEnemyMissilesList()
    {
        while (GameStateManager.State == GameState.Summary)
        {
            enemyMissilesList = GameObject.FindGameObjectsWithTag("EnemyMissile");

            print("enemyMissilesList.Length = "+ enemyMissilesList.Length);

            yield return new WaitForSeconds(1);

            if (enemyMissilesList.Length <= 1)
            {
                break;
            }
        }
        // Summary Cities + PlayerMissiles()
    }

    // Summary Cities + PlayerMissiles()
    // {
    //      SavedCitiesList = GameObject.FindGameObjectsWithTag("City");
    //      SavedPlayerMissilesInStorage = GameObject.FindGameObjectsWithTag("PlayerMissileInStorage");
    //      
    //
    // }
}
