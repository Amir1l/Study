<a name='assembly'></a>
# Study.LabWork1

## Contents

- [ComplexNumber](#T-Study-LabWork1-Features-Task1-ComplexNumber 'Study.LabWork1.Features.Task1.ComplexNumber')
  - [#ctor(real,imagine)](#M-Study-LabWork1-Features-Task1-ComplexNumber-#ctor-System-Double,System-Double- 'Study.LabWork1.Features.Task1.ComplexNumber.#ctor(System.Double,System.Double)')
  - [Imagine](#P-Study-LabWork1-Features-Task1-ComplexNumber-Imagine 'Study.LabWork1.Features.Task1.ComplexNumber.Imagine')
  - [Real](#P-Study-LabWork1-Features-Task1-ComplexNumber-Real 'Study.LabWork1.Features.Task1.ComplexNumber.Real')
  - [ToString()](#M-Study-LabWork1-Features-Task1-ComplexNumber-ToString 'Study.LabWork1.Features.Task1.ComplexNumber.ToString')
  - [op_Addition()](#M-Study-LabWork1-Features-Task1-ComplexNumber-op_Addition-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber- 'Study.LabWork1.Features.Task1.ComplexNumber.op_Addition(Study.LabWork1.Features.Task1.ComplexNumber,Study.LabWork1.Features.Task1.ComplexNumber)')
  - [op_Division()](#M-Study-LabWork1-Features-Task1-ComplexNumber-op_Division-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber- 'Study.LabWork1.Features.Task1.ComplexNumber.op_Division(Study.LabWork1.Features.Task1.ComplexNumber,Study.LabWork1.Features.Task1.ComplexNumber)')
  - [op_Equality()](#M-Study-LabWork1-Features-Task1-ComplexNumber-op_Equality-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber- 'Study.LabWork1.Features.Task1.ComplexNumber.op_Equality(Study.LabWork1.Features.Task1.ComplexNumber,Study.LabWork1.Features.Task1.ComplexNumber)')
  - [op_Inequality()](#M-Study-LabWork1-Features-Task1-ComplexNumber-op_Inequality-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber- 'Study.LabWork1.Features.Task1.ComplexNumber.op_Inequality(Study.LabWork1.Features.Task1.ComplexNumber,Study.LabWork1.Features.Task1.ComplexNumber)')
  - [op_Multiply()](#M-Study-LabWork1-Features-Task1-ComplexNumber-op_Multiply-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber- 'Study.LabWork1.Features.Task1.ComplexNumber.op_Multiply(Study.LabWork1.Features.Task1.ComplexNumber,Study.LabWork1.Features.Task1.ComplexNumber)')
  - [op_Subtraction()](#M-Study-LabWork1-Features-Task1-ComplexNumber-op_Subtraction-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber- 'Study.LabWork1.Features.Task1.ComplexNumber.op_Subtraction(Study.LabWork1.Features.Task1.ComplexNumber,Study.LabWork1.Features.Task1.ComplexNumber)')
  - [op_UnaryNegation()](#M-Study-LabWork1-Features-Task1-ComplexNumber-op_UnaryNegation-Study-LabWork1-Features-Task1-ComplexNumber- 'Study.LabWork1.Features.Task1.ComplexNumber.op_UnaryNegation(Study.LabWork1.Features.Task1.ComplexNumber)')
  - [op_UnaryPlus()](#M-Study-LabWork1-Features-Task1-ComplexNumber-op_UnaryPlus-Study-LabWork1-Features-Task1-ComplexNumber- 'Study.LabWork1.Features.Task1.ComplexNumber.op_UnaryPlus(Study.LabWork1.Features.Task1.ComplexNumber)')
- [IRunService](#T-Study-LabWork1-Shared-Abstractions-IRunService 'Study.LabWork1.Shared.Abstractions.IRunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask3')
- [Program](#T-Study-LabWork1-Program 'Study.LabWork1.Program')
  - [RUN_TASK_NUMBER](#F-Study-LabWork1-Program-RUN_TASK_NUMBER 'Study.LabWork1.Program.RUN_TASK_NUMBER')
  - [Main()](#M-Study-LabWork1-Program-Main 'Study.LabWork1.Program.Main')
- [RunService](#T-Study-LabWork1-Shared-Services-RunService 'Study.LabWork1.Shared.Services.RunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Services-RunService-RunTask1 'Study.LabWork1.Shared.Services.RunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Services-RunService-RunTask2 'Study.LabWork1.Shared.Services.RunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Services-RunService-RunTask3 'Study.LabWork1.Shared.Services.RunService.RunTask3')

<a name='T-Study-LabWork1-Features-Task1-ComplexNumber'></a>
## ComplexNumber `type`

##### Namespace

Study.LabWork1.Features.Task1

##### Summary

Класс, представляющий комплексное число

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-#ctor-System-Double,System-Double-'></a>
### #ctor(real,imagine) `constructor`

##### Summary

Конструктор класса ComplexNumber

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| real | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Реальная часть |
| imagine | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Воображаемая часть |

<a name='P-Study-LabWork1-Features-Task1-ComplexNumber-Imagine'></a>
### Imagine `property`

##### Summary

Воображаемая часть (только для чтения)

<a name='P-Study-LabWork1-Features-Task1-ComplexNumber-Real'></a>
### Real `property`

##### Summary

Реальная часть (только для чтения)

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-ToString'></a>
### ToString() `method`

##### Summary

Перегрузка метода ToString()

##### Returns

Строковое представление комплексного числа

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-op_Addition-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber-'></a>
### op_Addition() `method`

##### Summary

Сложение двух комплексных чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-op_Division-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber-'></a>
### op_Division() `method`

##### Summary

Деление двух комплексных чисел

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Появляется, если второе число равно нулю |

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-op_Equality-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber-'></a>
### op_Equality() `method`

##### Summary

Равенство двух комплексных чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-op_Inequality-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber-'></a>
### op_Inequality() `method`

##### Summary

Неравенство двух комплексных чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-op_Multiply-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber-'></a>
### op_Multiply() `method`

##### Summary

Умножение двух комплексных чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-op_Subtraction-Study-LabWork1-Features-Task1-ComplexNumber,Study-LabWork1-Features-Task1-ComplexNumber-'></a>
### op_Subtraction() `method`

##### Summary

Вычитание двух комплексных чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-op_UnaryNegation-Study-LabWork1-Features-Task1-ComplexNumber-'></a>
### op_UnaryNegation() `method`

##### Summary

Вычисление сопряженного комплексного числа

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-ComplexNumber-op_UnaryPlus-Study-LabWork1-Features-Task1-ComplexNumber-'></a>
### op_UnaryPlus() `method`

##### Summary

Вычисление модуля комплексного числа

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Shared-Abstractions-IRunService'></a>
## IRunService `type`

##### Namespace

Study.LabWork1.Shared.Abstractions

##### Summary

Интерфейс для реализации заданий Л/Р

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Запуск выполнения задания 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Запуск выполнения задания 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Запуск выполнения задания 3

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Program'></a>
## Program `type`

##### Namespace

Study.LabWork1

##### Summary

Начальная точка входа

<a name='F-Study-LabWork1-Program-RUN_TASK_NUMBER'></a>
### RUN_TASK_NUMBER `constants`

##### Summary

Номер выполняемой задачи

<a name='M-Study-LabWork1-Program-Main'></a>
### Main() `method`

##### Summary

Старт программы

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Shared-Services-RunService'></a>
## RunService `type`

##### Namespace

Study.LabWork1.Shared.Services

##### Summary

Реализация заданий Л/Р

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Задание 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Задание 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Задание 3

##### Parameters

This method has no parameters.
