<a name='assembly'></a>
# Study.LabWork2

## Contents

- [AsynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp')
  - [ExecuteRequestsAsync\`\`1()](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.ExecuteRequestsAsync``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
- [MonitorService](#T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService')
- [MutexService](#T-Study-LabWork2-Feature-Task1-SubTask1-MutexService 'Study.LabWork2.Feature.Task1.SubTask1.MutexService')
- [NumberSetProcessor](#T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor')
- [SemaphoreService](#T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService')
- [SynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp')

<a name='T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp'></a>
## AsynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Асинхронная версия приложения (с использованием async/await)

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequestsAsync\`\`1() `method`

##### Summary

Асинхронное выполнение запросов

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService'></a>
## MonitorService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 1. Использует Monitor (lock) для синхронизации

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MutexService'></a>
## MutexService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 2. Использует Mutex для синхронизации

<a name='T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor'></a>
## NumberSetProcessor `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask2

##### Summary

Определяет реализацию для процессора наборов чисел

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService'></a>
## SemaphoreService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 3. Использует бинарный Semaphore для синхронизации

<a name='T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp'></a>
## SynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Синхронная версия приложения (без использования async/await)
