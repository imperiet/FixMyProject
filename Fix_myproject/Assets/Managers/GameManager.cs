using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FixMyProject.GamePlay
{
    public enum GameState { Playing, Paused, EndScreen, StartScreen }

    public class GameManager : MonoBehaviour
    {
        public GameState gameState;
        public float playerMoveSpeed;
    }
}