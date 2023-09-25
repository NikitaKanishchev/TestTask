using TMPro;
using UnityEngine;


namespace View
{
    public class WinPanelController : MonoBehaviour
    {
        [SerializeField] private TMP_Text _winnerNickname = null;
        [SerializeField] private TMP_Text _coinCollected = null;
        
        public void SetNickName(string nickname)
        {
            _winnerNickname.text = nickname;
        }

        public void SetQuantityCoin(float coin)
        {
            _coinCollected.SetText("{0}", coin);
        }
    }
}