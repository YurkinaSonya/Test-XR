# Проект "Ведьмина хижина"
В данном репозитории представлена реализация тестового задания для VR-разработчика с использованием OpenXR: "Интерактивное виртуальное пространство". По условиям требовалось создать интерактивное виртуальное пространство, представляющее собой комнату с объектами, с которыми можно взаимодействовать. Благодаря абстактным формулировкам, помимо требуемых пунктов, были реализованы некоторые дополнительные элементы и дана воля фантазии. Но сначала проанализируем пункты из задания:
**Виртуальное пространство:** 
	создано виртуальное пространство, используя Unity с OpenXR;
	реализованы 2 сцены - меню и комната, в которых имеются различные объекты. 
**Интерактивность:** 
	реализована возможность перемещения по виртуальному пространству с помощью плавного перемещения;
	добавлены интерактивные элементы, такие как объекты-зелья, которые можно брать, и элементы интерфейса. 
**Анимация:**
	внедрены анимации, такие как анимация воды в меню и открытие книги в комнате. 
**Звук:**
	интегрирован трехмерные звуковые эффекты, улучшающие восприятие внутри комнаты;
**Графика (оптимизация):**
	Помимо общих оптимизирующих настроек проекта и камеры, был добавлен компонент post processing, одновременно улучшающий визуальный опыт и сохраняющий оптимизацию для VR.
**Дополнительные аспекты реализации:**
Помимо классического управления контроллерами, реализован почти полный функционал hand tracking, за исключением перемещения "на месте". Однако в пространстве, позволяющем физически передвигаться, это не является проблемой.
Большинство моделей (за исключением, в первую очередь, деревьев) были выполнены самостоятельно в программе blender, для которых почти все текстуры были сгенерированы с помощью stable diffusion. Особенности визуализации, такие как normal map и так далее, осознанно не были использованы, так как значительно ухудшали производительность (вполне возможно, что будет исправлено в дальнейшем);
Помимо основной сцены комнаты, была реализована сцена меню, предоставляющая вид снаружи на хижину ведьмы;
Внедрен NavMesh, позволяющий тонко настроить перемещение игрока по локации;
Активно использовались shader graph, например, для симуляции зелий в бутылках;
В папке "builds" расположен билд проекта для PC (к сожалению, в нем не доступен hand tracking, точнее, мне не удалось под это настроить свое устройство). Также планировался билд на android, но железо не позволяет, будет предпринята попытка билда на более мощном компьютере;
Реализована часть игрового функционала (не входило в тестовое задание) для создания зелий из имеющихся компонентов.
## Дальнейшее развитие
Так как была придумана механика изготовления зелий, хотелось бы закончить проект с этим и иным функционалом. Планируется добавление разрушения объектов, различных новых моделей для зелий и ингредиентов, добавление новых декораций внутри комнаты, создание заданий и так далее.

## Git
Разработка велась в логике, что main является доступной для разработчика веткой dev, из которой уже проводятся merge request в общий main команды. Хотелось бы также отметить, что в общем работа над проектом продлилась около недели, о чем можно удостовериться по истории коммитов.
