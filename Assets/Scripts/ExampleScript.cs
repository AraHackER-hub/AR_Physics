using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{

    //Определим возможные состояния врага в виде перечисления
    public enum EnemyState {CHASE, FLEE, FIGHT, HIDE};
    //Текущее состояние игрока
    public EnemyState ActiveState = EnemyState.CHASE;

    //Массив игровых объектов в сцене
    public GameObject[] MyObject;


    //Функция Start вызывается в момент запуска уровня
    //Заполним массив программно
    void Start()
    {
        MyObject = new GameObject[3]; //Ключевое слово new используется для создания массива с тремя элементами, по умолчанию значение null
        MyObject[0] = GameObject.Find("Main Camera");
        MyObject[1] = GameObject.Find("Directional Light"); //Функция производит поиск игрового объекта в активной сцене по имени
        MyObject[2] = GameObject.Find("GameObject");//Полученная ссылка помещается в указанный элемент массива

        foreach (GameObject obj in MyObject)
        {
            if (obj == MyObject[0]) continue;
            Destroy(obj); //Удаление объекта
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Проверить переменную ActiveState
        switch (ActiveState) {
            case EnemyState.FIGHT:
                {
                    Debug.Log("Entered fight state");
                }
                break;
            case EnemyState.FLEE:
            case EnemyState.HIDE:
                {
                    //Бегство и засада реализуются одинаково
                    Debug.Log("Entered flee or hide");
                }
                break;
            default:
                {
                    //Случай по умолчанию
                    //Когда другие случаи не подходят
                    Debug.Log("Entered chase state");
                }
                break;
        }

        
    }
}
