using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class YesorNo : MonoBehaviour
{
    public UnityEngine.UI.Text Word;
    public GameObject Press;
    public virtual void Start()
    {
        this.Word.text = "";
        this.Press.SetActive(true);
    }

    public virtual void yesorno()
    {
        int number = Random.Range(1, 3);
        this.Press.SetActive(false);
        if (number == 1)
        {
            this.Word.text = "Yes!";
        }
        else
        {
            if (number == 2)
            {
                this.Word.text = "No!";
            }
        }
    }

}