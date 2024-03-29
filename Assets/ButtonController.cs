using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject Button_0;
    [SerializeField] private int ButtonIndex;

    // Start is called before the first frame update
    void Start()
    {
        TMPro.TextMeshProUGUI buttonText = this.GetComponentInChildren<TMPro.TextMeshProUGUI>();
        buttonText.text = ButtonIndex.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ボタンが押されたらButton0の座標と入れ替える
    public void ChangeButtonPositionToZero() {
        // 押されたボタンを取得
//        Button clickedButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();

        // ボタン0と座標を入れ替える
        Vector3 tmpPosition = this.transform.position;
        this.transform.position = Button_0.transform.position;
        Button_0.transform.position = tmpPosition;
    }
}
