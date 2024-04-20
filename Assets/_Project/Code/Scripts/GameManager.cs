using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _scoreIncreaser;

    public BeamGenerator generator;
    public TextMeshProUGUI uiText;
    
    

    private void IncreaseScore()
    {
        _playerScore += _scoreIncreaser;
        uiText.text = _playerScore + "0";
    }
}
