-------------------------------------------------------------------------------
USE RuijiPortal
GO

SET IDENTITY_INSERT dbo.ArticleCategory ON 

-- [ArticleCategoryId]=1 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=1)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (1, N'News', NULL, N'��������', NULL, 0, '2013-12-21 14:22:39.003', N'Tony.Xu', '2013-12-21 14:22:39.003', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'News'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=NULL
	   , [IsDeleted]=0
	   , [CreateDate]='2013-12-21 14:22:39.003'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2013-12-21 14:22:39.003'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=1
GO

-- [ArticleCategoryId]=2 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=2)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (2, N'Solution', NULL, N'��������', NULL, 0, '2013-12-21 14:23:14.433', N'Tony.Xu', '2013-12-21 14:23:14.433', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'Solution'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=NULL
	   , [IsDeleted]=0
	   , [CreateDate]='2013-12-21 14:23:14.433'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2013-12-21 14:23:14.433'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=2
GO

-- [ArticleCategoryId]=3 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=3)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (3, N'Service', NULL, N'��������', NULL, 0, '2013-12-21 14:23:35.773', N'Tony.Xu', '2013-12-21 14:23:35.773', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'Service'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=NULL
	   , [IsDeleted]=0
	   , [CreateDate]='2013-12-21 14:23:35.773'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2013-12-21 14:23:35.773'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=3
GO

-- [ArticleCategoryId]=4 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=4)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (4, N'Achievement', NULL, N'�ɹ�����', NULL, 0, '2013-12-21 14:24:40.840', N'Tony.Xu', '2013-12-21 14:24:40.840', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'Achievement'
	   , [UIResourceId]=NULL
	   , [Description]=N'�ɹ�����'
	   , [ParentCategoryId]=NULL
	   , [IsDeleted]=0
	   , [CreateDate]='2013-12-21 14:24:40.840'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2013-12-21 14:24:40.840'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=4
GO

-- [ArticleCategoryId]=5 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=5)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (5, N'TechResource', NULL, N'�����ṩ', NULL, 0, '2013-12-21 14:25:28.763', N'Tony.Xu', '2013-12-21 14:25:28.763', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'TechResource'
	   , [UIResourceId]=NULL
	   , [Description]=N'�����ṩ'
	   , [ParentCategoryId]=NULL
	   , [IsDeleted]=0
	   , [CreateDate]='2013-12-21 14:25:28.763'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2013-12-21 14:25:28.763'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=5
GO

-- [ArticleCategoryId]=6 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=6)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (6, N'HumanResource', NULL, N'������Դ', NULL, 0, '2013-12-21 14:26:06.453', N'Tony.Xu', '2013-12-21 14:26:06.453', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'HumanResource'
	   , [UIResourceId]=NULL
	   , [Description]=N'������Դ'
	   , [ParentCategoryId]=NULL
	   , [IsDeleted]=0
	   , [CreateDate]='2013-12-21 14:26:06.453'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2013-12-21 14:26:06.453'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=6
GO

-- [ArticleCategoryId]=7 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=7)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (7, N'ContactUs', NULL, N'��ϵ����', NULL, 0, '2013-12-21 14:27:21.893', N'Tony.Xu', '2013-12-21 14:27:21.893', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ContactUs'
	   , [UIResourceId]=NULL
	   , [Description]=N'��ϵ����'
	   , [ParentCategoryId]=NULL
	   , [IsDeleted]=0
	   , [CreateDate]='2013-12-21 14:27:21.893'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2013-12-21 14:27:21.893'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=7
GO

-- [ArticleCategoryId]=8 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=8)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (8, N'CompanyInfo', NULL, N'�߽�����', NULL, 0, '2014-01-02 06:49:36.743', N'Tony', '2014-01-02 06:49:36.743', N'Tony')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'CompanyInfo'
	   , [UIResourceId]=NULL
	   , [Description]=N'�߽�����'
	   , [ParentCategoryId]=NULL
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-02 06:49:36.743'
	   , [CreateBy]=N'Tony'
	   , [UpdateDate]='2014-01-02 06:49:36.743'
	   , [UpdateBy]=N'Tony'
	WHERE [ArticleCategoryId]=8
GO

-- [ArticleCategoryId]=9 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=9)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (9, N'RongYuZiZhi', NULL, N'��������', 8, 0, '2014-01-03 08:50:56.737', N'Tony.Xu', '2014-01-03 08:50:56.737', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'RongYuZiZhi'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=8
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 08:50:56.737'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 08:50:56.737'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=9
GO

-- [ArticleCategoryId]=10 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=10)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (10, N'GongSiRongYu', NULL, N'��˾����', 9, 0, '2014-01-03 08:55:12.347', N'Tony.Xu', '2014-01-03 08:55:12.347', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'GongSiRongYu'
	   , [UIResourceId]=NULL
	   , [Description]=N'��˾����'
	   , [ParentCategoryId]=9
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 08:55:12.347'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 08:55:12.347'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=10
GO

-- [ArticleCategoryId]=11 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=11)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (11, N'GongSiZiZhi', NULL, N'��˾����', 9, 0, '2014-01-03 08:55:41.613', N'Tony.Xu', '2014-01-03 08:55:41.613', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'GongSiZiZhi'
	   , [UIResourceId]=NULL
	   , [Description]=N'��˾����'
	   , [ParentCategoryId]=9
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 08:55:41.613'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 08:55:41.613'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=11
GO

-- [ArticleCategoryId]=12 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=12)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (12, N'GongSiXinWen', NULL, N'��˾����', 1, 0, '2014-01-03 09:03:18.113', N'Tony.Xu', '2014-01-03 09:03:18.113', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'GongSiXinWen'
	   , [UIResourceId]=NULL
	   , [Description]=N'��˾����'
	   , [ParentCategoryId]=1
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:03:18.113'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:03:18.113'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=12
GO

-- [ArticleCategoryId]=13 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=13)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (13, N'MeiTiDongTai', NULL, N'ý�嶯̬', 1, 0, '2014-01-03 09:04:16.880', N'Tony.Xu', '2014-01-03 09:04:16.880', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'MeiTiDongTai'
	   , [UIResourceId]=NULL
	   , [Description]=N'ý�嶯̬'
	   , [ParentCategoryId]=1
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:04:16.880'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:04:16.880'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=13
GO

-- [ArticleCategoryId]=14 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=14)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (14, N'YeJieDongTai', NULL, N'ҵ�綯̬', 1, 0, '2014-01-03 09:04:38.643', N'Tony.Xu', '2014-01-03 09:04:38.643', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'YeJieDongTai'
	   , [UIResourceId]=NULL
	   , [Description]=N'ҵ�綯̬'
	   , [ParentCategoryId]=1
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:04:38.643'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:04:38.643'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=14
GO

-- [ArticleCategoryId]=15 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=15)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (15, N'ITCeLueYingYongGuiHua', NULL, N'IT����-Ӧ�ù滮', 2, 0, '2014-01-03 09:07:00.510', N'Tony.Xu', '2014-01-03 09:07:00.510', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ITCeLueYingYongGuiHua'
	   , [UIResourceId]=NULL
	   , [Description]=N'IT����-Ӧ�ù滮'
	   , [ParentCategoryId]=2
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:07:00.510'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:07:00.510'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=15
GO

-- [ArticleCategoryId]=16 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=16)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (16, N'ITGouJianJiChuSheJi', NULL, N'IT����-������Ƽ�Ӧ�ò���', 2, 0, '2014-01-03 09:11:19.797', N'Tony.Xu', '2014-01-03 09:11:19.797', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ITGouJianJiChuSheJi'
	   , [UIResourceId]=NULL
	   , [Description]=N'IT����-������Ƽ�Ӧ�ò���'
	   , [ParentCategoryId]=2
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:11:19.797'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:11:19.797'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=16
GO

-- [ArticleCategoryId]=17 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=17)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (17, N'JiChuSheShiZhongXin', NULL, N'������ʩ����', 16, 0, '2014-01-03 09:12:20.013', N'Tony.Xu', '2014-01-03 09:12:20.013', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'JiChuSheShiZhongXin'
	   , [UIResourceId]=NULL
	   , [Description]=N'������ʩ����'
	   , [ParentCategoryId]=16
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:12:20.013'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:12:20.013'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=17
GO

-- [ArticleCategoryId]=18 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=18)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (18, N'DaoPianFuWuQi', NULL, N'��Ƭ������', 17, 0, '2014-01-03 09:13:37.263', N'Tony.Xu', '2014-01-03 09:13:37.263', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'DaoPianFuWuQi'
	   , [UIResourceId]=NULL
	   , [Description]=N'��Ƭ������'
	   , [ParentCategoryId]=17
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:13:37.263'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:13:37.263'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=18
GO

-- [ArticleCategoryId]=19 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=19)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (19, N'XiaoXingJi', NULL, N'С�ͻ�', 17, 0, '2014-01-03 09:13:59.430', N'Tony.Xu', '2014-01-03 09:13:59.430', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'XiaoXingJi'
	   , [UIResourceId]=NULL
	   , [Description]=N'С�ͻ�'
	   , [ParentCategoryId]=17
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:13:59.430'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:13:59.430'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=19
GO

-- [ArticleCategoryId]=20 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=20)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (20, N'CunChu', NULL, N'�洢', 17, 0, '2014-01-03 09:14:21.503', N'Tony.Xu', '2014-01-03 09:14:21.503', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'CunChu'
	   , [UIResourceId]=NULL
	   , [Description]=N'�洢'
	   , [ParentCategoryId]=17
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:14:21.503'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:14:21.503'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=20
GO

-- [ArticleCategoryId]=21 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=21)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (21, N'WangLuoJiChuSheShi', NULL, N'���������ʩ', 17, 0, '2014-01-03 09:15:03.047', N'Tony.Xu', '2014-01-03 09:15:03.047', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'WangLuoJiChuSheShi'
	   , [UIResourceId]=NULL
	   , [Description]=N'���������ʩ'
	   , [ParentCategoryId]=17
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:15:03.047'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:15:03.047'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=21
GO

-- [ArticleCategoryId]=22 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=22)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (22, N'ShuJuKuChanPin', NULL, N'���ݿ��Ʒ', 17, 0, '2014-01-03 09:15:47.460', N'Tony.Xu', '2014-01-03 09:15:47.460', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ShuJuKuChanPin'
	   , [UIResourceId]=NULL
	   , [Description]=N'���ݿ��Ʒ'
	   , [ParentCategoryId]=17
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:15:47.460'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:15:47.460'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=22
GO

-- [ArticleCategoryId]=23 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=23)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (23, N'YingYongJiChengPingTai', NULL, N'Ӧ�ü���ƽ̨', 17, 0, '2014-01-03 09:16:26.663', N'Tony.Xu', '2014-01-03 09:16:26.663', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'YingYongJiChengPingTai'
	   , [UIResourceId]=NULL
	   , [Description]=N'Ӧ�ü���ƽ̨'
	   , [ParentCategoryId]=17
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:16:26.663'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:16:26.663'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=23
GO

-- [ArticleCategoryId]=24 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=24)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (24, N'ZiLiangZhongXin', NULL, N'��������', 16, 0, '2014-01-03 09:17:35.100', N'Tony.Xu', '2014-01-03 09:17:35.100', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ZiLiangZhongXin'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=16
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:17:35.100'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:17:35.100'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=24
GO

-- [ArticleCategoryId]=25 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=25)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (25, N'CeShiLiuChengJiQueXianGuanLi', NULL, N'�������̼�ȱ�ݹ���', 24, 0, '2014-01-03 09:18:44.363', N'Tony.Xu', '2014-01-03 09:18:44.363', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'CeShiLiuChengJiQueXianGuanLi'
	   , [UIResourceId]=NULL
	   , [Description]=N'�������̼�ȱ�ݹ���'
	   , [ParentCategoryId]=24
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:18:44.363'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:18:44.363'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=25
GO

-- [ArticleCategoryId]=26 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=26)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (26, N'ZiDongHuaCeShiRuanJian', NULL, N'�Զ����������', 24, 0, '2014-01-03 09:20:30.930', N'Tony.Xu', '2014-01-03 09:20:30.930', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ZiDongHuaCeShiRuanJian'
	   , [UIResourceId]=NULL
	   , [Description]=N'�Զ����������'
	   , [ParentCategoryId]=24
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:20:30.930'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:20:30.930'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=26
GO

-- [ArticleCategoryId]=27 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=27)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (27, N'XingNengZhongXin', NULL, N'��������', 16, 0, '2014-01-03 09:21:02.347', N'Tony.Xu', '2014-01-03 09:21:02.347', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'XingNengZhongXin'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=16
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:21:02.347'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:21:02.347'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=27
GO

-- [ArticleCategoryId]=28 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=28)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (28, N'XingNengCeShi', NULL, N'���ܲ���', 27, 0, '2014-01-03 09:21:50.830', N'Tony.Xu', '2014-01-03 09:21:50.830', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'XingNengCeShi'
	   , [UIResourceId]=NULL
	   , [Description]=N'���ܲ���'
	   , [ParentCategoryId]=27
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:21:50.830'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:21:50.830'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=28
GO

-- [ArticleCategoryId]=29 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=29)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (29, N'XingNengZhenDuan', NULL, N'�������', 27, 0, '2014-01-03 09:22:19.380', N'Tony.Xu', '2014-01-03 09:22:19.380', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'XingNengZhenDuan'
	   , [UIResourceId]=NULL
	   , [Description]=N'�������'
	   , [ParentCategoryId]=27
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:22:19.380'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:22:19.380'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=29
GO

-- [ArticleCategoryId]=30 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=30)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (30, N'AnQuanZhongXin', NULL, N'��ȫ����', 16, 0, '2014-01-03 09:22:51.593', N'Tony.Xu', '2014-01-03 09:22:51.593', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'AnQuanZhongXin'
	   , [UIResourceId]=NULL
	   , [Description]=N'��ȫ����'
	   , [ParentCategoryId]=16
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:22:51.593'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:22:51.593'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=30
GO

-- [ArticleCategoryId]=31 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=31)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (31, N'AnQuanSheBei', NULL, N'��ȫ�豸', 30, 0, '2014-01-03 09:23:54.447', N'Tony.Xu', '2014-01-03 09:23:54.447', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'AnQuanSheBei'
	   , [UIResourceId]=NULL
	   , [Description]=N'��ȫ�豸'
	   , [ParentCategoryId]=30
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:23:54.447'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:23:54.447'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=31
GO

-- [ArticleCategoryId]=32 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=32)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (32, N'FuWuQiZhengShu', NULL, N'������֤��', 30, 0, '2014-01-03 09:24:25.460', N'Tony.Xu', '2014-01-03 09:24:25.460', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'FuWuQiZhengShu'
	   , [UIResourceId]=NULL
	   , [Description]=N'������֤��'
	   , [ParentCategoryId]=30
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:24:25.460'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:24:25.460'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=32
GO

-- [ArticleCategoryId]=33 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=33)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (33, N'AnQuanSaoMiao', NULL, N'��ȫɨ��', 30, 0, '2014-01-03 09:24:49.297', N'Tony.Xu', '2014-01-03 09:24:49.297', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'AnQuanSaoMiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'��ȫɨ��'
	   , [ParentCategoryId]=30
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:24:49.297'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:24:49.297'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=33
GO

-- [ArticleCategoryId]=34 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=34)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (34, N'ITYunWei', NULL, N'IT��ά-Ӧ�ü��|������ά��', 2, 0, '2014-01-03 09:27:00.820', N'Tony.Xu', '2014-01-03 09:27:00.820', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ITYunWei'
	   , [UIResourceId]=NULL
	   , [Description]=N'IT��ά-Ӧ�ü��|������ά��'
	   , [ParentCategoryId]=2
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:27:00.820'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:27:00.820'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=34
GO

-- [ArticleCategoryId]=35 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=35)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (35, N'YinYongXiTongJianKong', NULL, N'Ӧ��ϵͳ��أ�HP��Bradmark��EMC��', 34, 0, '2014-01-03 09:34:12.300', N'Tony.Xu', '2014-01-03 09:34:12.300', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'YinYongXiTongJianKong'
	   , [UIResourceId]=NULL
	   , [Description]=N'Ӧ��ϵͳ��أ�HP��Bradmark��EMC��'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:34:12.300'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:34:12.300'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=35
GO

-- [ArticleCategoryId]=36 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=36)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (36, N'ShuJuCangKuJiShangYeZhiNeng', NULL, N'���ݲֿ⼰��ҵ����', 34, 0, '2014-01-03 09:35:17.493', N'Tony.Xu', '2014-01-03 09:35:17.493', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ShuJuCangKuJiShangYeZhiNeng'
	   , [UIResourceId]=NULL
	   , [Description]=N'���ݲֿ⼰��ҵ����'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:35:17.493'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:35:17.493'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=36
GO

-- [ArticleCategoryId]=37 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=37)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (37, N'ShuJuBeiFengJiGuiDang', NULL, N'���ݱ��ݼ��鵵', 34, 0, '2014-01-03 09:40:16.043', N'Tony.Xu', '2014-01-03 09:40:16.043', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ShuJuBeiFengJiGuiDang'
	   , [UIResourceId]=NULL
	   , [Description]=N'���ݱ��ݼ��鵵'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:40:16.043'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:40:16.043'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=37
GO

-- [ArticleCategoryId]=38 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=38)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (38, N'CunChuGuanLiJiWeiHu', NULL, N'�洢����ά��', 34, 0, '2014-01-03 09:40:45.403', N'Tony.Xu', '2014-01-03 09:40:45.403', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'CunChuGuanLiJiWeiHu'
	   , [UIResourceId]=NULL
	   , [Description]=N'�洢����ά��'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:40:45.403'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:40:45.403'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=38
GO

-- [ArticleCategoryId]=39 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=39)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (39, N'ShuJuKuDBAGuanLi', NULL, N'���ݿ�DBA����', 34, 0, '2014-01-03 09:42:38.287', N'Tony.Xu', '2014-01-03 09:42:38.287', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ShuJuKuDBAGuanLi'
	   , [UIResourceId]=NULL
	   , [Description]=N'���ݿ�DBA����'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:42:38.287'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:42:38.287'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=39
GO

-- [ArticleCategoryId]=40 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=40)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (40, N'ShuJuKuXingNengZhenDuanYuYouHua', NULL, N'���ݿ�����������Ż�', 34, 0, '2014-01-03 09:43:21.373', N'Tony.Xu', '2014-01-03 09:43:21.373', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ShuJuKuXingNengZhenDuanYuYouHua'
	   , [UIResourceId]=NULL
	   , [Description]=N'���ݿ�����������Ż�'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:43:21.373'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:43:21.373'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=40
GO

-- [ArticleCategoryId]=41 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=41)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (41, N'ShuJuKuSuiPianChongZu', NULL, N'���ݿ���Ƭ����', 34, 0, '2014-01-03 09:44:06.427', N'Tony.Xu', '2014-01-03 09:44:06.427', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ShuJuKuSuiPianChongZu'
	   , [UIResourceId]=NULL
	   , [Description]=N'���ݿ���Ƭ����'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:44:06.427'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:44:06.427'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=41
GO

-- [ArticleCategoryId]=42 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=42)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (42, N'QiYeJiSuanXuNiHua', NULL, N'��ҵ�������⻯', 34, 0, '2014-01-03 09:44:30.573', N'Tony.Xu', '2014-01-03 09:44:30.573', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'QiYeJiSuanXuNiHua'
	   , [UIResourceId]=NULL
	   , [Description]=N'��ҵ�������⻯'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:44:30.573'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:44:30.573'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=42
GO

-- [ArticleCategoryId]=43 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=43)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (43, N'WangLuoJianKongYuGuanLi', NULL, N'�����������', 34, 0, '2014-01-03 09:45:09.573', N'Tony.Xu', '2014-01-03 09:45:09.573', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'WangLuoJianKongYuGuanLi'
	   , [UIResourceId]=NULL
	   , [Description]=N'�����������'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:45:09.573'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:45:09.573'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=43
GO

-- [ArticleCategoryId]=44 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=44)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (44, N'ITILITSM', NULL, N'ITIL/ITSM����������', 34, 0, '2014-01-03 09:46:01.413', N'Tony.Xu', '2014-01-03 09:46:01.413', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ITILITSM'
	   , [UIResourceId]=NULL
	   , [Description]=N'ITIL/ITSM����������'
	   , [ParentCategoryId]=34
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:46:01.413'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:46:01.413'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=44
GO

-- [ArticleCategoryId]=45 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=45)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (45, N'FuWuNeiRongJieShao', NULL, N'�������ݽ���', 3, 0, '2014-01-03 09:46:54.000', N'Tony.Xu', '2014-01-03 09:46:54.000', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'FuWuNeiRongJieShao'
	   , [UIResourceId]=NULL
	   , [Description]=N'�������ݽ���'
	   , [ParentCategoryId]=3
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:46:54.000'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:46:54.000'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=45
GO

-- [ArticleCategoryId]=46 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=46)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (46, N'GaoJiZiXunFuWu', NULL, N'�߼���ѯ����', 45, 0, '2014-01-03 09:47:45.090', N'Tony.Xu', '2014-01-03 09:47:45.090', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'GaoJiZiXunFuWu'
	   , [UIResourceId]=NULL
	   , [Description]=N'�߼���ѯ����'
	   , [ParentCategoryId]=45
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:47:45.090'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:47:45.090'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=46
GO

-- [ArticleCategoryId]=47 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=47)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (47, N'ITYingYongGuiHua', NULL, N'ITӦ�ù滮��ѯ', 46, 0, '2014-01-03 09:48:32.687', N'Tony.Xu', '2014-01-03 09:48:32.687', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ITYingYongGuiHua'
	   , [UIResourceId]=NULL
	   , [Description]=N'ITӦ�ù滮��ѯ'
	   , [ParentCategoryId]=46
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:48:32.687'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:48:32.687'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=47
GO

-- [ArticleCategoryId]=48 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=48)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (48, N'CeShiShiYanShi', NULL, N'����ʵ������������Ľ�����ѯ', 46, 0, '2014-01-03 09:49:23.417', N'Tony.Xu', '2014-01-03 09:49:23.417', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'CeShiShiYanShi'
	   , [UIResourceId]=NULL
	   , [Description]=N'����ʵ������������Ľ�����ѯ'
	   , [ParentCategoryId]=46
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:49:23.417'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:49:23.417'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=48
GO

-- [ArticleCategoryId]=49 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=49)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (49, N'ZhuanYeShiShiFuWu', NULL, N'רҵʵʩ����', 45, 0, '2014-01-03 09:50:12.980', N'Tony.Xu', '2014-01-03 09:50:12.980', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ZhuanYeShiShiFuWu'
	   , [UIResourceId]=NULL
	   , [Description]=N'רҵʵʩ����'
	   , [ParentCategoryId]=45
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:50:12.980'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:50:12.980'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=49
GO

-- [ArticleCategoryId]=50 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=50)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (50, N'WangLuoGongCheng', NULL, N'���繤�̽������', 49, 0, '2014-01-03 09:50:51.260', N'Tony.Xu', '2014-01-03 09:50:51.260', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'WangLuoGongCheng'
	   , [UIResourceId]=NULL
	   , [Description]=N'���繤�̽������'
	   , [ParentCategoryId]=49
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:50:51.260'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:50:51.260'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=50
GO

-- [ArticleCategoryId]=51 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=51)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (51, N'YeWuChiXuXingYuHuiFuFuWu', NULL, N'ҵ���������ָ�����', 49, 0, '2014-01-03 09:51:50.917', N'Tony.Xu', '2014-01-03 09:51:50.917', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'YeWuChiXuXingYuHuiFuFuWu'
	   , [UIResourceId]=NULL
	   , [Description]=N'ҵ���������ָ�����'
	   , [ParentCategoryId]=49
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:51:50.917'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:51:50.917'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=51
GO

-- [ArticleCategoryId]=52 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=52)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (52, N'JiChuSheShi', NULL, N'������ʩ��ϵͳ�������', 49, 0, '2014-01-03 09:52:16.093', N'Tony.Xu', '2014-01-03 09:52:16.093', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'JiChuSheShi'
	   , [UIResourceId]=NULL
	   , [Description]=N'������ʩ��ϵͳ�������'
	   , [ParentCategoryId]=49
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:52:16.093'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:52:16.093'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=52
GO

-- [ArticleCategoryId]=53 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=53)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (53, N'RuanJianZiDongHua', NULL, N'����Զ������ܲ��Լ����ܲ���', 49, 0, '2014-01-03 09:53:07.713', N'Tony.Xu', '2014-01-03 09:53:07.713', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'RuanJianZiDongHua'
	   , [UIResourceId]=NULL
	   , [Description]=N'����Զ������ܲ��Լ����ܲ���'
	   , [ParentCategoryId]=49
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:53:07.713'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:53:07.713'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=53
GO

-- [ArticleCategoryId]=54 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=54)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (54, N'OracleZhuanYeFuWu', NULL, N'Oracleרҵ����', 49, 0, '2014-01-03 09:53:50.053', N'Tony.Xu', '2014-01-03 09:53:50.053', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'OracleZhuanYeFuWu'
	   , [UIResourceId]=NULL
	   , [Description]=N'Oracleרҵ����'
	   , [ParentCategoryId]=49
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:53:50.053'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:53:50.053'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=54
GO

-- [ArticleCategoryId]=55 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=55)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (55, N'ChanPinShouHouFuWu', NULL, N'��Ʒ�ۺ����', 45, 0, '2014-01-03 09:54:34.607', N'Tony.Xu', '2014-01-03 09:54:34.607', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ChanPinShouHouFuWu'
	   , [UIResourceId]=NULL
	   , [Description]=N'��Ʒ�ۺ����'
	   , [ParentCategoryId]=45
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:54:34.607'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:54:34.607'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=55
GO

-- [ArticleCategoryId]=56 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=56)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (56, N'KeHuJianSheJiTouSu', NULL, N'�ͻ����輰Ͷ��', 3, 0, '2014-01-03 09:55:54.603', N'Tony.Xu', '2014-01-03 09:55:54.603', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'KeHuJianSheJiTouSu'
	   , [UIResourceId]=NULL
	   , [Description]=N'�ͻ����輰Ͷ��'
	   , [ParentCategoryId]=3
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:55:54.603'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:55:54.603'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=56
GO

-- [ArticleCategoryId]=57 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=57)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (57, N'ZaiXIanKeFu', NULL, N'���߿ͷ�', 3, 0, '2014-01-03 09:56:17.207', N'Tony.Xu', '2014-01-03 09:56:17.207', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'ZaiXIanKeFu'
	   , [UIResourceId]=NULL
	   , [Description]=N'���߿ͷ�'
	   , [ParentCategoryId]=3
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:56:17.207'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:56:17.207'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=57
GO

-- [ArticleCategoryId]=58 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=58)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (58, N'KeHuLieBiao', NULL, N'�ͻ��б�', 4, 0, '2014-01-03 09:57:12.977', N'Tony.Xu', '2014-01-03 09:57:12.977', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'KeHuLieBiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'�ͻ��б�'
	   , [ParentCategoryId]=4
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:57:12.977'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:57:12.977'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=58
GO

-- [ArticleCategoryId]=59 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=59)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (59, N'AnLiFenXiang', NULL, N'��������', 4, 0, '2014-01-03 09:57:43.600', N'Tony.Xu', '2014-01-03 09:57:43.600', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'AnLiFenXiang'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=4
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:57:43.600'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:57:43.600'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=59
GO

-- [ArticleCategoryId]=60 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=60)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (60, N'FuWuTiXiZiLiao', NULL, N'������ϵ����', 5, 0, '2014-01-03 09:58:38.043', N'Tony.Xu', '2014-01-03 09:58:38.043', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'FuWuTiXiZiLiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'������ϵ����'
	   , [ParentCategoryId]=5
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:58:38.043'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:58:38.043'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=60
GO

-- [ArticleCategoryId]=61 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=61)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (61, N'HPChanPinZiLiao', NULL, N'HP��Ʒ����', 5, 0, '2014-01-03 09:59:16.060', N'Tony.Xu', '2014-01-03 09:59:16.060', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'HPChanPinZiLiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'HP��Ʒ����'
	   , [ParentCategoryId]=5
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:59:16.060'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:59:16.060'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=61
GO

-- [ArticleCategoryId]=62 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=62)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (62, N'EMCChanPinZiLiao', NULL, N'EMC��Ʒ����', 5, 0, '2014-01-03 09:59:29.650', N'Tony.Xu', '2014-01-03 09:59:29.650', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'EMCChanPinZiLiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'EMC��Ʒ����'
	   , [ParentCategoryId]=5
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:59:29.650'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:59:29.650'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=62
GO

-- [ArticleCategoryId]=63 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=63)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (63, N'VmwareChanPinZiLiao', NULL, N'Wmware��Ʒ����', 5, 0, '2014-01-03 09:59:53.393', N'Tony.Xu', '2014-01-03 09:59:53.393', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'VmwareChanPinZiLiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'Wmware��Ʒ����'
	   , [ParentCategoryId]=5
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 09:59:53.393'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 09:59:53.393'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=63
GO

-- [ArticleCategoryId]=64 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=64)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (64, N'OracleChanPinZiLiao', NULL, N'Oracle��Ʒ����', 5, 0, '2014-01-03 10:00:14.560', N'Tony.Xu', '2014-01-03 10:00:14.560', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'OracleChanPinZiLiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'Oracle��Ʒ����'
	   , [ParentCategoryId]=5
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 10:00:14.560'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 10:00:14.560'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=64
GO

-- [ArticleCategoryId]=65 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=65)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (65, N'BradmarkChanPinZiLiao', NULL, N'Bradmark��Ʒ����', 5, 0, '2014-01-03 10:00:31.240', N'Tony.Xu', '2014-01-03 10:00:31.240', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'BradmarkChanPinZiLiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'Bradmark��Ʒ����'
	   , [ParentCategoryId]=5
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 10:00:31.240'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 10:00:31.240'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=65
GO

-- [ArticleCategoryId]=66 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=66)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (66, N'QiTaChangShangChanPinZiLiao', NULL, N'�������̲�Ʒ����', 5, 0, '2014-01-03 10:00:54.560', N'Tony.Xu', '2014-01-03 10:00:54.560', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'QiTaChangShangChanPinZiLiao'
	   , [UIResourceId]=NULL
	   , [Description]=N'�������̲�Ʒ����'
	   , [ParentCategoryId]=5
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 10:00:54.560'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 10:00:54.560'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=66
GO

-- [ArticleCategoryId]=67 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=67)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (67, N'RenLiCeLue', NULL, N'��������', 6, 0, '2014-01-03 10:01:32.967', N'Tony.Xu', '2014-01-03 10:01:32.967', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'RenLiCeLue'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=6
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 10:01:32.967'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 10:01:32.967'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=67
GO

-- [ArticleCategoryId]=68 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=68)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (68, N'RenLiGouCheng', NULL, N'��������', 6, 0, '2014-01-03 10:02:21.203', N'Tony.Xu', '2014-01-03 10:02:21.203', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'RenLiGouCheng'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=6
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 10:02:21.203'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 10:02:21.203'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=68
GO

-- [ArticleCategoryId]=69 ---------------------------------
IF NOT EXISTS (SELECT * FROM dbo.ArticleCategory WHERE [ArticleCategoryId]=69)
    INSERT INTO dbo.ArticleCategory
    (
         [ArticleCategoryId]
       , [Name]
       , [UIResourceId]
       , [Description]
       , [ParentCategoryId]
       , [IsDeleted]
       , [CreateDate]
       , [CreateBy]
       , [UpdateDate]
       , [UpdateBy]
    )
    VALUES (69, N'JiaRuRuiJi', NULL, N'��������', 6, 0, '2014-01-03 10:02:47.520', N'Tony.Xu', '2014-01-03 10:02:47.520', N'Tony.Xu')
ELSE 
	UPDATE dbo.ArticleCategory SET 
	     [Name]=N'JiaRuRuiJi'
	   , [UIResourceId]=NULL
	   , [Description]=N'��������'
	   , [ParentCategoryId]=6
	   , [IsDeleted]=0
	   , [CreateDate]='2014-01-03 10:02:47.520'
	   , [CreateBy]=N'Tony.Xu'
	   , [UpdateDate]='2014-01-03 10:02:47.520'
	   , [UpdateBy]=N'Tony.Xu'
	WHERE [ArticleCategoryId]=69
GO

SET IDENTITY_INSERT dbo.ArticleCategory OFF
