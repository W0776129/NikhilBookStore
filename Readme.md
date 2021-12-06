

13-11-2021

2.1 Create DB

12:05PM Review appsettings.json
12:06PM Modify Database Name in json file
12:07PM apply migration using Nuget package manager
12:07PM change default project to NikhilBookStore.DataAccess
12:08PM Migration applied successfully
12:08PM Migration file name 20211113170400_AddDefaultIdentityMigration
12:10PM Github Commit
12:12PM Review Migration File
12:13PM update database using update-database statment applied in PM console.
12:14PM Review updated database in the sql server object explorer.
12:17PM for cheking error run the application.
12:23PM Created and modify new class file in .Model project named Category.cs

Break

12:59PM add migration via PM console
12:59PM update ApplicationDbContext got error
1:01PM update Category class (class created public) error solved
1:13PM re-run and add-migration 20211113181341_AddCategoyToDb
1:16PM Check database in sql soe
1:17PM run the application

2.1 Completed

2.2Repository started

1:25PM Created Repository in .DataAccess project
1:26PM Created IRepository inside that
1:28PM github Commit
1:28PM Created IRepository.cs inside IRpository
1:41PM IRepository.cs Modified added function and methods
1:47PM Created Repository.cs class file in Repository
1:48PM Implement Interface in it
1:58PM Created Constructor and dependancy injection in Repository.cs
1:58PM github commit

Break 

8:19PM Created individual repos for category
8:24PM Modified CategoryRepository.cs
8:28PM Modified ICategoryRepository.cs
8:30PM Add function in CategoryRepository.cs
8:50PM Created ISP_Call.cs and modify it
9:27PM Created SP_Call.cs and modify it

Break

10:25PM Created two files IUnitOfWork and UnitOfWork
10:28PM modify it and impelented it in startup.cs

Break

14-11-2021

10:57PM Created CategoryConroller.cs
11:06PM Modified CategotyController.cs
11:09PM Created Category folder in View of Admin
11:09PM Created index.cshtml in that folder
11:12PM Add content in index.cshtml 
11:16PM Run the application 
11:23PM link of admin view to dropdown menu
11:30PM Re eun application and checked navigation
11:41PM Two icons added from FontAwesom 
11:45PM Created Category.js file and add code
11:50PM Run the Applicaton got error


15-11-2021

12:17AM Solve the error by change in Repository.cs
12:25AM check application by adding new data in table

Break

10:02AM I know about extended PPt so code is left.
10:08AM Modified CategoryController.cs for upsert vire controll
10:15AM Upsert.cshtml created and content addeed into it
10:23AM New file _CreateAndBackToListButton created and modfied it for view of Create.
10:26AM New file _EditAndBackToListButton created and modfied it for view of Edit.
10:44AM Modified Upsert.cshtml and index.cshtml

Break

11:23AM Run the application and check
11:25AM Script added into upsert.cshtml for validaton
11:30AM Modified CategoryContoller.cs for add method for upster
11:40AM run the appication Edit not working
11:52AM Added Api call for delete data in CategoryController.js
12:21PM Function added in Categor.js and link to run the function for delete data
12:22PM delete function not working

Break 

2:54PM Delete function working in some browser(College Lab Computer Edge Browser)



2021-11-28

4:25 Error solving Analyze whole project
5:55PM Error Solved for Edit Category

1 hour for error solving

9:04PM CoverType.cs file created and modified in Model project
9:05PM Add CoverTypeRepository Class
9:15PM Add ICoverTypeRepository Interface
9:18PM Add CoverType to UnitOfWork and IUnitofWork
9:25PM Applied Migration 20211129023329_AddCoverTypeToDb
9:30PM update database

28Min

11:13PM Add Cover Type to NavBar
11:16PM Add CoverType Controller with all required Action Methods
11:21PM Cover Type Index View to use DataTables
11:25PM Cover Type Upsert View takes care of creating and updating CoverType
11:30PM The delete CoverType is done using the API Call.
11:32PM run the applicaton covertype done

18Min

3.1 total hour 46Min

2021-11-30

5:03PM Add a new class (Product) in the .Models project 
5:15PM Add refrence into Application DBcontext
5:18PM add migraion  20211129042337_AddProductToDb
5:32PM Created IProductRepository
5:38PM Created ProductRepository
5:43PM Added product into unitof work and Iunitwork
5:48PM Created Viewmmodel in Model
5:55PM Modify ProductController
6:03PM Add index view
6:05PM add link to Layout file for poroduct
6:15PM Creaed upsert file
6:18PM Account open in tiny.cloud
6:25PM applied tiny.cloud  validation  in upsert

1:30 hour total

2021-12-01
4:18PM add image folder 
4:20PM post method uncomment in productcontroller
4:21PM run the application got error
4:28PM error for covertype list is solved
4:53PM error for GetAll method parameter is solved

40Min

2021-12-02 
1:58PM error solved for loading product entry page
 

2021-12-06

9:33AM Starting Analysing Github link provided https://github.com/Rico-Jose/BulkyBook
9:39AM Modified  ProductController.cs
9:41AM Product.cs Model updated
9:45AM ProductRepository.cs modified new criteria added in update method
9:50AM SD.cs Class update
9:56AM Product upsert view updated
10:00AM HomeController updated in Customers area
10:07AM Views for customer area updated
10:10AM Datbase error need to update database

40Min

Break

10:49AM Migration added 20211206154419_AddProductToDb1
11:01AM Some error for fetching data customer view is fine

20Min

Break

12:15AM View update and try to solve error.
10 Min

Till now Total time spent on Part 4 is 70 Min
