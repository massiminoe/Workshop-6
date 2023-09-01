// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Instructions;

    public void Play() {
        SceneManager.LoadScene("MainScene");
    }

    public void ShowMenu() {
        this.Menu.SetActive(true);
        this.Instructions.SetActive(false);
    }
    public void ShowInstructions() {
        this.Menu.SetActive(false);
        this.Instructions.SetActive(true);
    }
}
