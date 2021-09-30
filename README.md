# WORK-FROM-HOME-APP
Work form home application which is just like a freelancer and over here i focused more on the back end connection.
               “WORK FROM HOME” 
			 	by: Shiva sai karne 					

Problem statement:

People who are well-qualified but not able to do full time work due to some responsibilities and for some other reason along with that many organization can not supervise to get qualified employee to get their work to be done.So, these organizations cannot afford to keep a full time employee for their project or business.
WORK FROM HOME will be the platform in communication between such recruiters and employees, and help them to complete their needs. Here employees can find their part time job based upon their qualification and also Company can get their employee who can work for an affordable pay. Recruiter will upload some work with providing descriptions regarding the work along with budget. WORK FROM HOME.So based on the information provided by the recruiter, employee will place a bid. Recruiter will hire the employee who placed the best bid and had a good qualification. After the completion of work employee will submit the work and with required documentation, then the payment method will be initiated.

WORK FROM HOME SPECIFICATIONS
⦁	There are two types of users: “Admin” and “Normal” users.
Admin user: can manage entire your system, so can access any data.In addition, admin user can access daily/weekly reports.
Normal user can be both recruiter and employee.
⦁	Normal user can be both “recruiter” and “employee” 
⦁	Normal user can register the system, and then sign-in the system 
⦁	Normal user can be recruiter, so he can able to post a work in auction
⦁	Other normal user can able to see all the available bids and he can bid on that work, and give some decription about himself.
⦁	Payment system can be online, such as transactions. 
⦁	Submission is done by uploading the file and required documentation.
⦁	Recruiter and employee rate the service each other.
⦁	Recruiter can send a message to employee regarding to the bidding work. 
⦁	Normal user can send a message to Admin user regarding to any issue. 
⦁	Admin user can see the receive the message and related items.
⦁	Employee must agree the terms and conditions provided by the Recruiter.
⦁	Normal users must accepts the terms and conditions provided by the admin.
⦁	Admin can able to block any users , if they find any suspicious activity form them.
⦁	Help servies is given to users by admin.
⦁	Only selected person by recruiter can only be communicate with them.

Assumption: 
⦁	The description provided by the recruiter and the employee is genuine.
⦁	N number of employees can work for ONE recruiter
⦁	N number of works can be posted by ONE recruiter.


EER modeling
 
Creating Relations


Relational Algebra
s skills=”C++” (Employee)
sJob type=”Developer” (Job)
sdeadline=”11/01/2019” (work assign)
sptype=”Gpay” (Payment)
srating=”4” (Employee)
P (Job)
Pid, name (Employee)
sskills=”java” AND rating>”4” (Employee)
sskills=”java” AND ratingt=”3” (Employee)
Ppid, pamount (Payment)
PUID ,Uname (USER)
spdate=”11/21/2019”AND pamount > “500” (Payment)
s pdate=”11/21/2019”AND pamount < “500” (Payment)
sblockid (Admin)
sbid=”123”AND b_min=”10” (biding)
sJ_budget=”200”  (Job)
sUID=”1234”OR SSN=”13243527152” (Employee)
s UID=”1234”OR SSN=”13243527152” (Recruiter)
