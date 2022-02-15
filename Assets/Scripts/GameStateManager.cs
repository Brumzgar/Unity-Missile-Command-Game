using System.Collections;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    public static GameState State;

    private bool gameOverFlag;

    [SerializeField]
    private EnemyMissileManager enemyMissileManager;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateGameState(GameState.LevelStart);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.LevelStart:
                LevelStartState();
                break;
            case GameState.EnemyMissileWave:
                EnemyMissileWaveState();
                break;
            case GameState.Summary:
                SummaryState();
                break;
            case GameState.GameOver:
                GameOverState();
                break;
        }
    }

    private void Update()
    {
        if (EnemyMissileManager.enemyTargetList.Length == 1 && gameOverFlag == false)
        {
            gameOverFlag = true;
            UpdateGameState(GameState.GameOver);
        }

    }
    private void GameOverState()
    {
        print("GameOverState()");

    }

    private void SummaryState()
    {
        print("SummaryState()");
        ScoreManager.StartSummary();
    }

    private void EnemyMissileWaveState()
    {
        print("EnemyMissileWaveState()");
        StartCoroutine(EnemyMissileWaves());
    }

    private void LevelStartState()
    {
        print("LevelStartState()");
    }

    IEnumerator EnemyMissileWaves()
    {
        while (State == GameState.EnemyMissileWave)
        {
            for (int i = 0; i <= 3; i++)
            {
                enemyMissileManager.EnemyMissilesWave();
                yield return new WaitForSeconds(5);
            }
            break;
        }
        // UpdateGameState(GameState.Summary); - za szybko sie odpala i wylacz strzelanie,
        // zmienic ze najpier sprawdza lista pociski wroga a potem jest summary
    }
}

public enum GameState
{
    LevelStart,
    EnemyMissileWave,
    Summary,
    GameOver
}

