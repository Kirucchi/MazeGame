using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Maze mazePrefab;
    private Maze mazeInstance;

    public GameObject LetterE, LetterA, LetterS, LetterY;
    private GameObject InstanceE, InstanceA, InstanceS, InstanceY;

    public GameObject player;
    private GameObject playerInstance;

    public GameObject managerPrefab;
    private GameObject managerInstance;

    public GameObject computerPrefab;
    private GameObject computerInstance;

    public GameObject goal;
    private GameObject goalInstance;

    private void BeginGame() {
        mazeInstance = Instantiate(mazePrefab) as Maze;
        mazeInstance.Generate();
        //StartCoroutine(mazeInstance.Generate());
        Vector3 positionE = new Vector3((int)Random.Range(-10.0f, 10.0f) + 0.2f, 0.0f, (int)Random.Range(-10.0f, 10.0f) + 0.3f);
        Vector3 positionA = new Vector3((int)Random.Range(-10.0f, 10.0f) + 0.2f, 0.0f, (int)Random.Range(-10.0f, 10.0f) + 0.3f);
        Vector3 positionS = new Vector3((int)Random.Range(-10.0f, 10.0f) + 0.2f, 0.0f, (int)Random.Range(-10.0f, 10.0f) + 0.3f);
        Vector3 positionY = new Vector3((int)Random.Range(-10.0f, 10.0f) + 0.2f, 0.0f, (int)Random.Range(-10.0f, 10.0f) + 0.3f);
        InstanceE = Instantiate(LetterE) as GameObject;
        InstanceE.transform.localPosition = InstanceE.transform.localPosition + positionE;
        InstanceA = Instantiate(LetterA) as GameObject;
        InstanceA.transform.localPosition = InstanceA.transform.localPosition + positionA;
        InstanceS = Instantiate(LetterS) as GameObject;
        InstanceS.transform.localPosition = InstanceS.transform.localPosition + positionS;
        InstanceY = Instantiate(LetterY) as GameObject;
        InstanceY.transform.localPosition = InstanceY.transform.localPosition + positionY;
        playerInstance = Instantiate(player);
        playerInstance.transform.localPosition = new Vector3(-9.5f, 0.0f, -9.5f);
        vThirdPersonCamera script = (vThirdPersonCamera) Camera.main.GetComponent("vThirdPersonCamera");
        script.target = playerInstance.transform;
        computerInstance = Instantiate(computerPrefab);
        computerInstance.transform.localPosition = new Vector3(-9.5f, 0.5f, -9.5f);
        goalInstance = Instantiate(goal);
        goalInstance.transform.localPosition = new Vector3(9.5f, 0.5f, 9.5f);

        managerInstance = Instantiate(managerPrefab);// as Transform;
    }

    private void RestartGame() {
        StopAllCoroutines();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /*
        Destroy(mazeInstance.gameObject);
        Destroy(InstanceE.gameObject);
        Destroy(InstanceA.gameObject);
        Destroy(InstanceS.gameObject);
        Destroy(InstanceY.gameObject);
        Destroy(playerInstance.gameObject);
        Destroy(managerInstance.gameObject);
        Destroy(goalInstance.gameObject);
        Destroy(GameObject.Find("Computer(Clone)"));
        Destroy(GameObject.Find("MoveCPU(Clone)"));
        GameObject.Find("ImageE").GetComponent<Image>().enabled = false;
        GameObject.Find("ImageA").GetComponent<Image>().enabled = false;
        GameObject.Find("ImageS").GetComponent<Image>().enabled = false;
        GameObject.Find("ImageY").GetComponent<Image>().enabled = false;
        GameObject.Find("FishBowl").GetComponent<Image>().enabled = false;
        GameObject.Find("LoseText").GetComponent<Text>().enabled = false;
        GameObject.Find("WinText").GetComponent<Text>().enabled = false;
        BeginGame();
        */
    }

    private void Start() {
        BeginGame();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            RestartGame();
        }
    }
}