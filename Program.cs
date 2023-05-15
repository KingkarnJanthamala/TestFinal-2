using System;

class Program {
    static void Main(string[] args) {
        float Vmax = float.Parse(Console.ReadLine()); //Vmax คือความจุของถังน้ำ 
        float Vdrink = float.Parse(Console.ReadLine()); //Vdrink คือ ปริมาตรน้ำเฉลี่ยที่ผู้เข้าร่วมโครงการดื่มในแต่ละช่วงพัก
        float Vfill = float.Parse(Console.ReadLine()); //Vfill คือ  ปริมาตรน้ำที่เติมได้ในแต่ละรอบเติมน้ำ
        int tdrink = int.Parse(Console.ReadLine()); //tdrink คือ ระยะเวลาคั่นระหว่างช่วงพัก
        int tfill = int.Parse(Console.ReadLine()); //tfill คือ ระยะเวลาคั่นระหว่างรอบเติมน้ำ
        int tday = int.Parse(Console.ReadLine()); //tday คือ ระยะเวลารวมของกิจกรรมตั้งแต่เริ่มจนจบวัน
    }
}