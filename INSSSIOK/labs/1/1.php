<?php
function printStudents(array $students): void{
    foreach ($students as $student) {
        print_r($student);
        echo "</br>";
    }
}
function genereteStudents(): array
{
    $names = ["adam", "aarem", "belkim", "barim"];
    $list0fStudents = [];
    for ($i = 0; $i < 3; $i++) {
        $grades = [];
        for ($j = 0; $j < 3; $j++) {
            $grades[$j] = rand(1, 100);
        }

        $student = [

            "name" => $names[rand(0, count($names) - 1)],

            "age" => rand(1, 100),

            "grades" => $grades

        ];
        $list0fStudents[$i] = $student;
    }
    return $list0fStudents;
}

$students = genereteStudents();
printStudents($students);

echo "<br>";

echo "Дел 1: Пресметување на Просечна Оценка";
echo "<br>";
echo "<br>";



function calculateAverage(array $grades): float
{
    return round(array_sum($grades) / count($grades),2);
}

$studentIndex = 0;


echo "Average grade of student " . $students[$studentIndex]['name'] . " is: " . calculateAverage($students[$studentIndex]['grades']);

echo "<br>";
echo "<br>";

echo "Дел 2: Филтрирање на Студенти по Возраст";
echo "<br>";
echo "<br>";


function filterByAge( array $students, int $age): array
{
    return array_filter($students, function ($student) use ($age) {
        return $student['age'] > $age;
    });
}

$age=20;

echo "Filter all students by age >". $age ."<br>";
echo "<br>";

$filteredStudents=filterByAge($students, $age);
printStudents($filteredStudents);


echo "<br>";
echo "Дел 3: Голема Буква за Имињата на Студентите";
echo "<br>";


function capitalizeNames(array $students): array
{
    for($i=0;$i<count($students);$i++){
        $students[$i]['name']=
            strtoupper($students[$i]['name'][0])
            .substr($students[$i]['name'],1,strlen($students[$i]['name'])-1);
    }
    return $students;
}

echo "<br>";

printStudents(capitalizeNames($students));

echo "<br>";
echo "Дел 4: Прикажување на Студенти";
echo "<br>";
echo "<br>";


function displayStudents(array $students) : void
{
    foreach ($students as $student){
        echo "Name: ".$student['name'].", Age: ".$student['age'].", Average Grade: ".round(calculateAverage($student['grades']),2)."<br>";
    }
}

displayStudents($students);



echo "<br>";
echo "Дополнителен дел: Сортирај Студенти по Име";
echo "<br>";
echo "<br>";


usort($students, function ($a, $b) {
    return strcmp($a['name'], $b['name']);
});

displayStudents($students);




?>