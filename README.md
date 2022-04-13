# FormtasksCsFileDirectoryDateTime

Task-1:

Exceptions

- NotFoundException

Status class
- Id  
- Title
- Content
- SharedDate - DateTime tipindən bir property, statusdan yeni bir obyekt yaranan zaman yarandığı tarix set olunacaq.
- GetStatusInfo() - geriyə "Title: test title - Content: test content - shared 5 seconds ago"(burda qeyd olunan "shared 5 seconds ago" hissəsi dinamik olmalıdı
  status neçə saniyə əvvəl paylaşılıbsa o yazılmalıdı) bu tipdə bir məlumat qaytaracaq.

ps: Title, content olmadan status obyekti yaratmaq olmaz.

User class
- Id
- Statuses - status obyektlərini özündə saxlayan bir list olacaq.
- Username
- ShareStatus() - parametr olaraq bir status obyekti qəbul edib statuses listinə əlavə edəcək.

- GetStatusById() - parametr olaraq nullable int tipindən bir id qəbul edəcək həmin id-li statusu tapıb geriyə qaytaracaq.

- GetAllStatuses() - geriyə user-in bütün statuslarını qaytaracaq.

- FilterStatusByDate() - parametr olaraq DateTime tipindən bir tarix qəbul edəcək göndərilən  user-in həmin tarixdən sonra paylaşılan
  bütün statuslarını geriyə qaytaracaq, göndərilən tarixdən sonra heç bir status paylaşılmayıbsa NotFoundException baş verəcək.

ps: Username olmadan user obyekti yaratmaq olmaz.

Program class


Menu
1. Share status
2. Get all statuses
3. Get status by id
4. Filter status by date
0. Quit
