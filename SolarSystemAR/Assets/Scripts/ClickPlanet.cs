using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ClickPlanet : MonoBehaviour
{
    public GameObject mercury, venus, earth, mars, jupiter, saturn, uranus, neptune;
    public GameObject messageBox;
    public Text message;
    float timeSpn;
    float checkTime;

    // Start is called before the first frame update
    void Start()
    {
        mercury = GameObject.Find("Mercury");
        venus = GameObject.Find("Venus");
        earth = GameObject.Find("Earth");
        mars = GameObject.Find("Mars");
        jupiter = GameObject.Find("Jupiter");
        saturn = GameObject.Find("Saturn");
        uranus = GameObject.Find("Uranus");
        neptune = GameObject.Find("Neptune");
        messageBox = GameObject.Find("messageBox");
        message = GameObject.Find("message").GetComponent<Text>();

        messageBox.SetActive(false);

        timeSpn = 0;
        checkTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        onClickPlanet();
    }

    public void onClickPlanet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Mercury")
                {
                    Debug.Log("Mercury touched");
                    message.text = "������ �¾���� ù ��° �༺�̸�, ������ ������ �ܿ� ��Ⱑ ���� �������� �ʴ´�.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Venus")
                {
                    Debug.Log("Venus touched");
                    message.text = "�ݼ� ����� �ּ����� �̻�ȭź���̰�, ��κ��� �༺���� �ٸ��� �ݴ�� ������ �Ѵ�.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Earth")
                {
                    Debug.Log("Earth touched");
                    message.text = "�츮�� ��� �ִ� �༺�̸�, �¾���� �� ��° �༺�̴�.\n" +
                        "������ ���� ����, ���, ��, �Ƹ���, �̻�ȭź�� ������ �̷���� �ִ�.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Mars")
                {
                    Debug.Log("Mars touched");
                    message.text = "ȭ���� �¾�� �༺ �� ���� ������ �ִ�.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Jupiter")
                {
                    Debug.Log("Jupiter touched");
                    message.text = "���� �¾�迡�� ���� �Ŵ��� �༺�̸�, ���� ������ �����Ѵ�.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Saturn")
                {
                    Debug.Log("Saturn touched");
                    message.text = "�伺�� �Ƹ��ٿ� ���� ���� �ִ� �༺�̴�. �񼺿� �̾� �¾�迡�� �� ��°�� ũ��.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Uranus")
                {
                    Debug.Log("Uranus touched");
                    message.text = "���������� �߰ߵ� ������ �༺�̸�, õ�ռ��� ��⿡�� ���Ұ� �� 83%, ����� 15%, ��ź 2% ���� ���ԵǾ� �ִٰ� �Ѵ�.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
                if (hit.collider.name == "Neptune")
                {
                    Debug.Log("Neptune touched");
                    message.text = "�ؿռ��� ���� �������� �߰ߵ� �༺�̴�. �ؿռ��� ���� õ�ռ��� ���� �ſ� ����ϸ�, �µ� ���� õ�ռ��� ����ϴٰ� �Ѵ�.";
                    messageBox.SetActive(true);
                    timeSpn += Time.deltaTime;

                    if (timeSpn >= checkTime)
                    {
                        messageBox.SetActive(false);
                        timeSpn = 0;
                    }
                }
            }
        }
    }
}
