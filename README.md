# PD-Medicine
The application is an online registry for patients who want to make an appointment with their local doctor.

# First Use:

1. Start project
2. In URL write: ~http://localhost:port/Home/FakeAdmin
3. Admin Create in SqlDateBase: Username: admin, Password: admin
4. Login as admin. Admin have permission to create/edit/delete doctors
5. In URL write: ~http://localhost:port/Home/FakeUser
6. User Create in SqlDateBase: Username: user, Password: user
7. Login as user. User have permission to create/edit/delete/sent/resent appointments
8. Register work too. Register create new User.
9. In URL write: ~http://localhost:port/Home/FakeDoctor
11. Doctor Create in SqlDateBase: Username: doctor, Password: doctor
10. Login as doctor. Doctor have permission to approved/declined/delete/view appointments

FakeDoctor and FakeUser is only for test mode. If you add new user, register user. If you add new doctor, add with admin account!
