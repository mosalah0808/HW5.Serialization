using HW5.Serialization;
using System.Text.Json;

var data = new F();

int iterations = 10000;

var timeCsv = SerializationCSV.SerializeCSVIterationTimes(data, iterations, false);
var timeCsvConsole = SerializationCSV.SerializeCSVIterationTimes(data, iterations, true);

var timeJson = SerializationJson.SerializeJsonIterationTimes(data, iterations, false);
var timeJsonConsole = SerializationJson.SerializeJsonIterationTimes(data, iterations, true);

string csv = SerializationCSV.SerializeFromObjectToCSV(data);
var timeCSVDeserialise = DeserializationCSV.DeserializeFromCSVIterationTimes(csv, iterations);

string json = JsonSerializer.Serialize(data);
var timeJsonDeserialise = DeSerializationJson.DeserializeJson<F>(json, iterations);

Console.WriteLine($"Сериализация в CSV без вывода в консоль: {timeCsv}");
Console.WriteLine($"Сериализация в CSV с выводом в консоль: {timeCsvConsole}");

Console.WriteLine($"Сериализация в JSON без вывода в консоль: {timeJson}");
Console.WriteLine($"Сериализация в JSON с выводом в консоль: {timeJsonConsole}");

Console.WriteLine($"Десериализация из CSV : {timeCSVDeserialise}");
Console.WriteLine($"Десериализация из JSON: {timeJsonDeserialise}");

Console.ReadLine();