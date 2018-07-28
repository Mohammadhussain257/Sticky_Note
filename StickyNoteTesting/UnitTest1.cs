using System;
using Mohammad_StickyNote;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StickyNoteTesting
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void logintesting()
        {
            string username = "admin";
            string password = "admin";

            LoginBLL checkLogin = new LoginBLL();
            checkLogin._username = username;
            checkLogin._password = password;

            bool actualResult = checkLogin.CheckUser();
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void loginTesting_for_invalid_user_Testing()
        {
            string username = "invalidUser";
            string password = "invalidPassword";
            LoginBLL checkLoginUser = new LoginBLL();
            checkLoginUser._username = username;
            checkLoginUser._password = password;
            bool actualResult = checkLoginUser.CheckUser();
            bool expectedResult = true;
            Assert.AreEqual(expectedResult,actualResult);
        }
        [TestMethod]
        public void check_if_category_exist_testing()
        {
            string categoryName = "Book";
            int userId = 2;
            addCategoryBLL addcategorybll = new addCategoryBLL();
            bool actualResult = addcategorybll.checkCategory(userId,categoryName);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void addCategory_Testing()
        {
            addCategoryBLL addCategorybll = new addCategoryBLL();

            int expectedCount = addCategorybll.countAddCategory() + 1;
            int userId = 2;
            string category = "addingcategy";
            addCategorybll.addCetegory(userId, category);

            int actualCount = addCategorybll.countAddCategory();
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void signup_registration_Testing()
        {
            RegisterBLL checkRegiseterbll = new RegisterBLL();

            int ExpectedCount = checkRegiseterbll.countUser()+1;

            checkRegiseterbll._fname = "test";
            checkRegiseterbll._lname = "test1";
            checkRegiseterbll._username = "demo";
            checkRegiseterbll._password = "notdisplay";
            checkRegiseterbll._email = "example@gmail.com";
            checkRegiseterbll._dob = "2018/07/19";
            checkRegiseterbll._confirmpassword = "notdisplay";
            checkRegiseterbll._gender = "Male";
            checkRegiseterbll.insertUserInfo();

            int actualCount = checkRegiseterbll.countUser();

            Assert.AreEqual(ExpectedCount, actualCount);

        }
        
        [TestMethod]
        public void createNote_Test()
        {
            CreateNoteBll createNote = new CreateNoteBll();

            int expectedCount = createNote.countNote() + 1;
            createNote.insertNoteInfo(2,1,"NoteTitle","NoteCategory","NoteContent");
            int actualCount = createNote.countNote();
            Assert.AreEqual(expectedCount,actualCount);
        }

        [TestMethod]
        public void deleteNote_Testing()
        {
             CreateNoteBll createNote = new CreateNoteBll();
            int expectedCount = createNote.countNote() - 1;
            StickyNoteBLL deleteNote = new StickyNoteBLL();
            int noteId = 34;
            deleteNote.deleteStickyNote(noteId);
            int actualCount = createNote.countNote();
            Assert.AreEqual(expectedCount,actualCount);
        }

        [TestMethod]
        public void update_StickyNote_status_to_1_Testing()
        {
            StickyNoteBLL stickyNote = new StickyNoteBLL();
            int expectedResult_count = stickyNote.countComplete_Sticky_Note_();
            int noteId = 4;
            stickyNote.completeStickyNote(noteId);
            int actualResult_Count = stickyNote.countComplete_Sticky_Note_();
            Assert.AreEqual(expectedResult_count, actualResult_Count);

        }

        [TestMethod]
        public void updateAccount_setting_Testing()
        {
            AccountSettingbll accountSettingbll = new AccountSettingbll();
            int ExpectedCount = accountSettingbll.countUpdateAccount();
            string fname = "test";
            string lname = "test1";
            string username = "demo";
            string password = "notdisplay";
            string email = "example@gmail.com";
            string dob = "2018/07/19";
            string confirmpassword = "notdisplay";
            string gender = "Male";
            int userid = 2;
            accountSettingbll.updateAccountSetting(userid,fname,lname,gender,dob,email,username,password,confirmpassword);
            int actualCount = accountSettingbll.countUpdateAccount();
            Assert.AreEqual(ExpectedCount,actualCount);
        }

        [TestMethod]
        public void valid_email_confirmation_test()
        {
            string email = "example@gmail.com";
            sendEmailBLL checkEmail = new sendEmailBLL();
            checkEmail._email = email;
            bool actualResult = checkEmail.checkEmail();
            bool expectedtResult = true;
            Assert.AreEqual(expectedtResult,actualResult);
        }
        [TestMethod]
        public void invalid_email_Check_test()
        {
            string email = "invalid_email@gmail.com";
            sendEmailBLL checkEmail = new sendEmailBLL();
            checkEmail._email = email;
            bool actualResult = checkEmail.checkEmail();
            bool expectedtResult = true;
            Assert.AreEqual(expectedtResult, actualResult);
        }

        [TestMethod]
        public void reset_account_for_valid_email_testing()
        {
            ResetAccountBLL reset_account = new ResetAccountBLL();
            int expectResult_Count = reset_account.countReset_account();
            string newUsername = "Test";
            string newPassword = "password";
            string confirmPassword = "password";
            string email = "test@gmail.com";
            reset_account._newUsername = newUsername;
            reset_account._newPassword = newPassword;
            reset_account._confirmPassword = confirmPassword;
            reset_account.resetAccount(email);
            int actualResult = reset_account.countReset_account();
            Assert.AreEqual(expectResult_Count, actualResult);
        }

    }
}
