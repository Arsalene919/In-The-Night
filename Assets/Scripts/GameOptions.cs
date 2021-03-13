using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOptions : MonoBehaviour
{
    public Slider slider;
    public Button PlusButton;
    public GameObject Nbre_Loup;
    public GameObject Nbre_Villageois;
    public GameObject Nbre_Spéciaux;

    public int NbreLoup;
    public int NbreVillageois;
    public int NbreSpéciaux;

     public float NbreJoueur = 8.0f;


    void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        Button btn = PlusButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        //Nbre_Loup.text = Nbre_Loup.ToString();
        //Find the GameObject named PlusButton in the scene
        //GameObject buttonGameObject = GameObject.Find("PlusButton");
        //Get the GUIText Component attached to that GameObject named PlusButton
        //Nbre_Loup = buttonGameObject.GetComponent<UnityEngine.UI.Text>();

    }

    private void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderbarCallBack(slider.value); });
    }
    void Update()
    {
       
    }

    public void sliderbarCallBack(float value)
    {
        float NbreJoueurIncreased = NbreJoueur + 1.0f;
        for (float i=8.0f; i<=30.0f; i++) 
        {
            if (NbreJoueurIncreased >= 30.0f) break;
        }
        
       
    }

    public void TaskOnClick()
    {
        Nbre_Loup.GetComponent<UnityEngine.UI.Text>().text = NbreLoup.ToString();
        do
        {
           NbreLoup++;
        }

        while (NbreLoup >= 13);
    }

    public void PlusVill()
    {
        Nbre_Villageois.GetComponent<UnityEngine.UI.Text>().text = NbreVillageois.ToString();
        do
        {
            NbreVillageois++;
        }

        while (NbreVillageois >= 16);
    }

    public void PlusSpec()
    {
        Nbre_Spéciaux.GetComponent<UnityEngine.UI.Text>().text = NbreSpéciaux.ToString();
        do
        {
            NbreSpéciaux++;
        }

        while (NbreSpéciaux >= 4);
    }

    public void MoinsVill()
    {
        Nbre_Villageois.GetComponent<UnityEngine.UI.Text>().text = NbreVillageois.ToString();
        do
        {
            NbreVillageois--;
        }
        while (NbreVillageois <= 0);
    }

    public void MoinsSpec()
    {
        Nbre_Spéciaux.GetComponent<UnityEngine.UI.Text>().text = NbreSpéciaux.ToString();
        do
        {
            NbreSpéciaux--;
        }

        while (NbreSpéciaux <= 0);
    }
}
