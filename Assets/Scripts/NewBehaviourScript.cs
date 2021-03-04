using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    public Text pawAmount;
    private int paws;

    public void onclick()
    {
        paws++;
        pawAmount.text = paws + "";
    }
}
