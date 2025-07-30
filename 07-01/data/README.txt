# Database Restoration Guide

This guide provides the steps to restore the following two databases using SQL Server Management Studio (SSMS):
1. aspnet-WingtipToys.bak
2. WingtipToys.bak

## Prerequisites:
- SQL Server Management Studio (SSMS) installed.
- Backup files `aspnet-WingtipToys.bak` and `WingtipToys.bak` available.

## Steps to Restore the Databases:

### 1. Open SQL Server Management Studio (SSMS)
- Launch SSMS and connect to your SQL Server instance.

### 2. Restore `aspnet-WingtipToys.bak` Database
1. In the "Object Explorer" pane, right-click on the **Databases** folder.
2. Select **Restore Database**.
3. In the **Restore Database** window, choose **Device**.
4. Click on the ellipsis (`...`) button next to **Device** to open the "Select backup devices" dialog.
5. Click **Add** and browse to the location where `aspnet-WingtipToys.bak` is stored.
6. Select `aspnet-WingtipToys.bak` and click **OK**.
7. In the "Restore Database" window, ensure that the database name is set to `aspnet-WingtipToys` or any desired name.
8. Click **OK** to restore the database.

### 3. Restore `WingtipToys.bak` Database
1. In the "Object Explorer" pane, right-click on the **Databases** folder.
2. Select **Restore Database**.
3. In the **Restore Database** window, choose **Device**.
4. Click on the ellipsis (`...`) button next to **Device** to open the "Select backup devices" dialog.
5. Click **Add** and browse to the location where `WingtipToys.bak` is stored.
6. Select `WingtipToys.bak` and click **OK**.
7. In the "Restore Database" window, ensure that the database name is set to `WingtipToys` or any desired name.
8. Click **OK** to restore the database.

### 4. Verify the Restoration
- After restoring both databases, check the **Databases** folder in SSMS to ensure both `aspnet-WingtipToys` and `WingtipToys` databases are listed.

You have now successfully restored the `aspnet-WingtipToys.bak` and `WingtipToys.bak` databases.

## Troubleshooting:
- Ensure that you have sufficient permissions to restore databases on the SQL Server instance.
- Make sure that the backup files are not corrupted or missing.
