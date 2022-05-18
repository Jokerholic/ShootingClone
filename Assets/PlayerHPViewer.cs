using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerHP playerHP;
    private Slider sliderHP;

    private void Awake()
    {
        sliderHP = GetComponent<Slider>();
    }

    // Update is called once per frame
    private void Update()
    {
        sliderHP.value = playerHP.CurrentHP / playerHP.MaxHP;
    }
}
