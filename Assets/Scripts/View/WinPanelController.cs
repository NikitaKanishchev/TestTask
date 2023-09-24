using System;
using TMPro;
using UnityEngine;

namespace View
{
    public class WinPanelController : MonoBehaviour
    {
        [SerializeField] private TMP_Text _winnerNickname = null;
        [SerializeField] private TMP_Text _goldsCollected = null;

        private void OnEnable()
        {
            
        }
    }
}