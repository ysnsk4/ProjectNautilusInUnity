using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField]
    Text _label;

    void Update()
    {
        int number = PlayerController.GoldCount;

        //int count = (int)(Time.time);
        _label.text = $"Count: {number}";

        //_label.color = Color.white;
        if (number >= 3)
        {
            _label.color = Color.green;
        }
    }
}