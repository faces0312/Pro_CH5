using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Data : MonoBehaviour
{
    static GameObject _container;

    static GameObject Container
    {
        get
        {
            return _container;
        }
    }
    static Data _instance;

    public static Data Instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "Data";
                _instance = _container.AddComponent(typeof(Data)) as Data;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    public string GameDataFileName = "ProCh5.json";  //이름 변경 절대 X 



    public GameData _gameData;

    public GameData gameData
    {
        get
        {
            if (_gameData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _gameData;
        }
    }

    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;
        if (File.Exists(filePath))
        {
            Debug.Log("불러오기 성공!");
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }
        else
        {
            Debug.Log("새로운 파일 생성");
            _gameData = new GameData();
        }
    }

    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(gameData);
        string filePath = Application.persistentDataPath + GameDataFileName;
        File.WriteAllText(filePath, ToJsonData);
        Debug.Log("저장 완료");
    }
    private void OnApplicationQuit()
    {
        SaveGameData();
    }
}
