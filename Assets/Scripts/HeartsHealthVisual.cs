using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsHealthVisual : MonoBehaviour
{
    [SerializeField] private Sprite heartSprite;

    private void Start() {
        CreateHeartImage(new Vector2(0, 0));
        CreateHeartImage(new Vector2(20, 0));
        CreateHeartImage(new Vector2(40, 0));
    }

    private Image CreateHeartImage(Vector2 anchoredPosition){
        GameObject heartGameObject = new GameObject("Heart", typeof(Image));

        heartGameObject.transform.parent = transform;
        heartGameObject.transform.localPosition = Vector3.zero;

        heartGameObject.GetComponent<RectTransform>().anchoredPosition = anchoredPosition;
        heartGameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(10, 10);

        Image heartImage = heartGameObject.GetComponent<Image>();
        heartImage.sprite = heartSprite;

        return heartImage;
    }
}
