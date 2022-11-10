using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattlePass : MonoBehaviour
{
   public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
