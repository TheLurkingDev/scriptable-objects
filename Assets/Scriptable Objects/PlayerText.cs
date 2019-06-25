using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjects
{
    public class PlayerText : MonoBehaviour
    {
        [SerializeField]
        private FloatVariable _playerHp;
        private Text _playerText;

        private void Start()
        {
            _playerText = GetComponent<Text>();
            if(_playerHp != null) { _playerText.text = "HP: " + _playerHp.Value.ToString();  }
        }
    }
}
