using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate2CreateTriggerForAccounting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //migrationBuilder.Sql(@"
            //  CREATE TRIGGER Accounting.trg_AccountingDataAccount_INS
	           //     ON Accounting.AccountingDataAccount
	           //     AFTER INSERT
            //    AS 
            //    BEGIN
	           //     SET NOCOUNT ON;

	           //     --Cannot function on more than 1 inserted record at a time
	           //     IF (SELECT COUNT(1) FROM Inserted) > 1
	           //     BEGIN
		          //      RAISERROR (N'This table does not support multiple inserts in one SQL statement', 18, 1)

		          //      DELETE FROM Accounting.AccountingDataAccount
		          //      WHERE NoUrutAccountId IN (SELECT NoUrutAccountId FROM Inserted)

		          //      RETURN
	           //     END

	           //     --If Root node, simply place at the end (right) of all other Roots (i.e. max-right)
	           //     IF ((SELECT Parent FROM Inserted) IS NULL
		          //      OR (SELECT Parent FROM Inserted) = -1) -- root node
	           //     BEGIN
		          //      DECLARE @Left INT	

		          //      SELECT @Left = COALESCE(MAX(Rgt), 0) + 1
		          //      FROM Accounting.AccountingDataAccount
		
		          //      UPDATE Accounting.AccountingDataAccount
		          //      SET Lft = @Left, Rgt = @Left + 1, Depth = 0
		          //      WHERE NoUrutAccountId = (SELECT NoUrutAccountId FROM Inserted)
	           //     END
	           //     --Else, shift ALL sub-trees over (right) by 2
	           //     --& place the newly Inserted at the tail-end (right) of its siblings
	           //     ELSE
	           //     BEGIN
		          //      DECLARE @ParentRight INT, @Depth INT

		          //      SELECT @ParentRight = Rgt, @Depth = Depth + 1
		          //      FROM Accounting.AccountingDataAccount
		          //      WHERE NoUrutAccountId = (SELECT Parent FROM Inserted)

		          //      --SHIFT EVERYTHING ELSE OVER (right) 2
		          //      UPDATE Accounting.AccountingDataAccount
		          //      SET Lft = CASE WHEN Lft > @ParentRight THEN Lft + 2 ELSE Lft END
		          //        , Rgt = CASE WHEN Rgt >= @ParentRight THEN Rgt + 2 ELSE Rgt END
		          //      WHERE Rgt >= @ParentRight

		          //      --new record goes below (to the right of) its right-most sibling

            //            UPDATE Accounting.AccountingDataAccount

            //            SET Lft = @ParentRight, Rgt = @ParentRight + 1
            //              , Depth = @Depth

            //            WHERE NoUrutAccountId = (SELECT NoUrutAccountId FROM Inserted)

            //        END
            //    END
               
            //    ");

            //migrationBuilder.Sql(@"

            //        CREATE TRIGGER Accounting.trg_AccountingDataAccount_DEL
	           //         ON Accounting.AccountingDataAccount
	           //         INSTEAD OF DELETE
            //        AS 
            //        BEGIN
	           //         SET NOCOUNT ON;

	           //         --Cannot function on more than 1 deleted record at a time
	           //         IF (SELECT COUNT(1) FROM Deleted) > 1
	           //         BEGIN
		          //          RAISERROR (N'This table does not support multiple inserts in one SQL statement', 18, 1)
		          //          RETURN
	           //         END

	           //         --Get properties of deleting node
	           //         DECLARE @DelID INT, @DelParentID INT
		          //          , @DelLeft INT, @DelRight INT
		          //          , @DelDepth INT

	           //         SELECT @DelID = NoUrutAccountId, @DelParentID = Parent
		          //          , @DelLeft = Lft, @DelRight = Rgt
		          //          , @DelDepth = Depth
	           //         FROM Deleted

	           //         --Ready to delete the node
	           //         DELETE FROM Accounting.AccountingDataAccount
	           //         WHERE NoUrutAccountId = @DelID

	           //         --If furthest right root node, no need to move any others
	           //         IF (@DelRight = (SELECT MAX(Rgt) FROM Accounting.AccountingDataAccount))
		          //          RETURN;

	           //         --Else, we have to shift nodes left & promote children
	           //         ELSE
	           //         BEGIN
		          //          --shift everything left 2
		          //          UPDATE Accounting.AccountingDataAccount
		          //          SET Lft = (CASE WHEN Lft > @DelRight THEN Lft - 2 ELSE Lft END)
		          //            , Rgt = (CASE WHEN Rgt >= @DelRight THEN Rgt - 2 ELSE Rgt END)
		          //          WHERE Rgt >= @DelRight

		          //          --If leaf node, no need to move children.
		          //          --Else, shift nodes back (left) by 2, if they are above / right of the deleted node;
            //                --then we need to promote children to next level up(or they'll be orphans!)
            //                --Children will be placed in deleted node's space, i.e. squeezed between its old neighbors.

            //                IF(EXISTS(SELECT 1

            //                            FROM Accounting.AccountingDataAccount child

            //                            WHERE child.Parent = @DelID))

            //                BEGIN
            //                    --set childrens' ParentID to old Parent, up Depth by 1, & subtract 1 from Positions

            //                    UPDATE Accounting.AccountingDataAccount

            //                    SET Parent = @DelParentID, Depth = @DelDepth
            //                        , Lft = Lft - 1, Rgt = Rgt - 1

            //                    WHERE Parent = @DelID

            //                END

            //            END
            //        END
                  
            //");

            //migrationBuilder.Sql(@"
            //               CREATE TRIGGER Accounting.trg_AccountingDataAccount_UPD
	           //             ON Accounting.AccountingDataAccount
	           //             INSTEAD OF UPDATE
            //            AS 
            //            BEGIN
	           //             SET NOCOUNT ON;

	           //             --Don't allow updates to structural fields (Position, Depth) nor parent; really, you can only update Name.
	           //             IF (EXISTS (SELECT 1
		          //              FROM Deleted
		          //              JOIN Inserted
			         //               ON Inserted.NoUrutAccountId = Deleted.NoUrutAccountId
		          //              WHERE Deleted.Parent <> Inserted.Parent
			         //               OR Deleted.Lft <> Inserted.Lft
			         //               OR Deleted.Rgt <> Inserted.Rgt
			         //               OR Deleted.Depth <> Inserted.Depth
		          //              ))
	           //             BEGIN
		          //              RAISERROR (N'Cannot update position/parent values inline; use the dedicated stored-procedure to move nodes.', 18, 1)
		          //              RETURN
	           //             END

	           //             --Don't allow updates to NULL values
	           //             IF (EXISTS (SELECT 1
		          //              FROM Deleted
		          //              JOIN Inserted
			         //               ON Inserted.NoUrutAccountId = Deleted.NoUrutAccountId
		          //              WHERE Inserted.Parent IS NULL
			         //               OR Inserted.Lft IS NULL
			         //               OR Inserted.Rgt IS NULL
			         //               OR Inserted.Depth IS NULL
		          //              ))
	           //             BEGIN
		          //              RAISERROR (N'Cannot update values to NULL; use the dedicated stored-procedure to set a node to root (NULL parent).', 18, 1)

            //                    RETURN

            //                END

            //                --Else, proceed with update-- you can only update the Name!
            //                UPDATE Accounting.AccountingDataAccount SET Accounting.AccountingDataAccount.Account = Inserted.Account

            //                FROM Accounting.AccountingDataAccount

            //                JOIN Inserted

            //                    ON Inserted.NoUrutAccountId = Accounting.AccountingDataAccount.NoUrutAccountId
            //            END
                       

            //    ");

            //migrationBuilder.Sql(@"

            //                CREATE PROCEDURE [dbo].[MoveAccountSubtree]
	           //                 @NoUrutAccountId INT
	           //                 , @NewParent INT
	           //                 , @Debug BIT = 0
            //                AS
            //                BEGIN
	           //                 SET NOCOUNT ON;

	           //                 --Disable triggers during operations
	           //                 ALTER TABLE Accounting.AccountingDataAccount DISABLE TRIGGER trg_AccountingDataAccount_DEL;
	           //                 ALTER TABLE Accounting.AccountingDataAccount DISABLE TRIGGER trg_AccountingDataAccount_INS;
	           //                 ALTER TABLE Accounting.AccountingDataAccount DISABLE TRIGGER trg_AccountingDataAccount_UPD;

	           //                 --Treat 0/-1/NULL the same: means we want to make the top of this subtree a Root node
	           //                 IF (@NewParent <= 0 OR @NewParent IS NULL)
	           //                 BEGIN
		          //                  SET @NewParent = -1;
	           //                 END

	           //                 --Cannot move a subtree under itself
	           //                 ELSE IF @NewParent IN (
		          //                  SELECT SubCat.NoUrutAccountId
		          //                  FROM Accounting.AccountingDataAccount Cat
		          //                  JOIN Accounting.AccountingDataAccount SubCat
				        //                    ON SubCat.Lft BETWEEN Cat.Lft AND Cat.Rgt
		          //                  WHERE Cat.NoUrutAccountId = @NoUrutAccountId)
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot move subtree to a node within itself.', 18, 1);
		          //                  RETURN;
	           //                 END

	           //                 --Cannot move subtree to a node that doesnt exist
	           //                 ELSE IF NOT EXISTS (SELECT 1 FROM Accounting.AccountingDataAccount WHERE NoUrutAccountId = @NewParent)
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot move subtree to a node that doesn''t exist.', 18, 1);
		          //                  RETURN;
	           //                 END

	           //                 --Cannot move subtree that doesnt exist
	           //                 ELSE IF NOT EXISTS (SELECT 1 FROM Accounting.AccountingDataAccount WHERE NoUrutAccountId = @NoUrutAccountId)
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot move subtree that doesn''t exist.', 18, 1);
		          //                  RETURN;
	           //                 END

	           //                 --Get old Parent & Subtree size
	           //                 DECLARE @OldParent INT
		          //                  , @SubtreeSize INT
		          //                  , @SubtreeOldLeft INT
		          //                  , @SubtreeOldRight INT
		          //                  , @SubtreeOldDepth INT

	           //                 SELECT @OldParent = Parent,  @SubtreeSize = Rgt - Lft + 1
		          //                  , @SubtreeOldLeft = Lft, @SubtreeOldRight = Rgt, @SubtreeOldDepth = Depth
	           //                 FROM Accounting.AccountingDataAccount
	           //                 WHERE NoUrutAccountId = @NoUrutAccountId

	           //                 --Cannot move subtree to its own Parent, i.e. there's nothing to do b/c new parent is same as old
	           //                 IF @OldParent = @NewParent
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot move subtree to its own parent.', 18, 1);
		          //                  RETURN;
	           //                 END

	           //                 --Get new Parent position
	           //                 DECLARE @NewParentRight INT
		          //                  , @NewParentDepth INT;

	           //                 --If we're going Root, place it to the Right of existing Roots
	           //                 IF @NewParent = -1
	           //                 BEGIN
		          //                  SELECT @NewParentRight = MAX(Rgt) + 1, @NewParentDepth = -1
		          //                  FROM Accounting.AccountingDataAccount
	           //                 END
	           //                 --Else, place it to the Right of its new siblings-to-be
	           //                 ELSE
	           //                 BEGIN
		          //                  SELECT @NewParentRight = Rgt, @NewParentDepth = Depth
		          //                  FROM Accounting.AccountingDataAccount 
		          //                  WHERE NoUrutAccountId = @NewParent
	           //                 END

	           //                 --Get new positions for use
	           //                 SELECT NoUrutAccountId
		          //                  , Lft + @NewParentRight - @SubtreeOldLeft AS PLeft
		          //                  , Rgt + @NewParentRight - @SubtreeOldLeft AS PRight
		          //                  , Depth + (@NewParentDepth - @SubtreeOldDepth) + 1 AS Depth
	           //                 INTO #MoveNodes
	           //                 FROM Accounting.AccountingDataAccount
	           //                 WHERE NoUrutAccountId IN (
		          //                  SELECT SubCat.NoUrutAccountId
		          //                  FROM Accounting.AccountingDataAccount Cat
		          //                  JOIN Accounting.AccountingDataAccount SubCat
				        //                    ON SubCat.Lft BETWEEN Cat.Lft AND Cat.Rgt
		          //                  WHERE Cat.NoUrutAccountId = @NoUrutAccountId
	           //                 )

	           //                 IF (@Debug = 1)
		          //                  SELECT * FROM #MoveNodes
		          //                  ORDER BY PLeft

	           //                 --Make gap in tree (at destination branch) equal to the SubtreeSize
	           //                 UPDATE Accounting.AccountingDataAccount
	           //                 SET Lft = CASE WHEN Lft > @NewParentRight THEN Lft + @SubtreeSize ELSE Lft END,
		          //                  Rgt = CASE WHEN Rgt >= @NewParentRight THEN Rgt + @SubtreeSize ELSE Rgt END
	           //                 WHERE Rgt >= @NewParentRight

	           //                 --Update Subtree positions to new ones
	           //                 UPDATE Accounting.AccountingDataAccount
	           //                 SET Lft = #MoveNodes.PLeft, Rgt = #MoveNodes.PRight, Depth = #MoveNodes.Depth
	           //                 FROM Accounting.AccountingDataAccount
	           //                 JOIN #MoveNodes
			         //                   ON Accounting.AccountingDataAccount.NoUrutAccountId = #MoveNodes.NoUrutAccountId

	           //                 --Maintain the Adjacency-List part (set ParentID)
	           //                 UPDATE Accounting.AccountingDataAccount
	           //                 SET Parent = (CASE WHEN @NewParent = -1 THEN NULL ELSE @NewParent END)
	           //                 WHERE NoUrutAccountId = @NoUrutAccountId

	           //                 --Close gaps, i.e. after the Subtree is gone from its old Parent, said old parent node has no children;
	           //                 --while nodes to the right & above now have inflated values, except where they include the newly moved subtree.
	           //                 UPDATE Accounting.AccountingDataAccount
	           //                 SET Lft = CASE WHEN Lft > @SubtreeOldRight THEN Lft - @SubtreeSize ELSE Lft END,
		          //                  Rgt = CASE WHEN Rgt >= @SubtreeOldRight THEN Rgt - @SubtreeSize ELSE Rgt END
	           //                 WHERE Rgt >= @SubtreeOldRight

	           //                 --Re-enable triggers when done
	           //                 ALTER TABLE Accounting.AccountingDataAccount ENABLE TRIGGER trg_AccountingDataAccount_DEL;
	           //                 ALTER TABLE Accounting.AccountingDataAccount ENABLE TRIGGER trg_AccountingDataAccount_INS;
	           //                 ALTER TABLE Accounting.AccountingDataAccount ENABLE TRIGGER trg_AccountingDataAccount_UPD;
            //                END
                             

            //");

            //migrationBuilder.Sql(@"
            //                          CREATE PROCEDURE [dbo].[RebuildAccountTree]
	           //                         @Parent INT = NULL
	           //                         , @Position INT = 0
	           //                         , @Depth INT = 0
            //                        AS
            //                        BEGIN
	           //                         SET NOCOUNT ON;
	
	           //                         --Starting depth; we will set this to the given Parent's Depth (or 0 if NULL)
	           //                         --DECLARE @Depth INT
	           //                         /*
	           //                         SELECT @Depth = (CASE WHEN @ParentID IS NULL THEN 0 ELSE Depth END)
		          //                          FROM nsm.Cat
		          //                          WHERE (@ParentID IS NULL AND ParentID IS NULL)
			         //                           OR ParentID = @ParentID
	           //                         */

	           //                         --Cursor (loop) over child nodes of the given ParentID
	           //                         DECLARE @Curff CURSOR 
	           //                         SET @Curff = CURSOR READ_ONLY FAST_FORWARD FOR
		          //                          SELECT NoUrutAccountId
		          //                          FROM Accounting.AccountingDataAccount
		          //                          WHERE (@Parent IS NULL AND Parent IS NULL)
			         //                           OR Parent = @Parent
		          //                          ORDER BY Lft

	           //                         DECLARE @NoUrutAccountId INT
	           //                         OPEN @Curff
	           //                         FETCH NEXT FROM @Curff INTO @NoUrutAccountId

	           //                         WHILE @@FETCH_STATUS = 0
	           //                         BEGIN
		          //                          --Assumption: @Position starts at the CORRECT # from the given parent
		          //                          SET @Position = @Position + 1

		          //                          --@Depth gets incremented when you travel down from parent to child
		          //                          SET @Depth = @Depth + 1

		          //                          --Update this node's PLeft & Depth
		          //                          ALTER TABLE Accounting.AccountingDataAccount DISABLE TRIGGER trg_AccountingDataAccount_UPD;

		          //                          UPDATE Accounting.AccountingDataAccount SET Lft = @Position, Depth = @Depth
		          //                          WHERE NoUrutAccountId = @NoUrutAccountId

		          //                          ALTER TABLE Accounting.AccountingDataAccount ENABLE TRIGGER trg_AccountingDataAccount_UPD;

		          //                          --Recursively re-number this node's children
		          //                          RAISERROR ('Calling RebuildAccountTree %d, %d --at Depth=%d', 0, 1, @NoUrutAccountId, @Position, @Depth) WITH NOWAIT
		
		          //                          EXEC @Position = RebuildAccountTree @NoUrutAccountId, @Position, @Depth

		          //                          --It returns the last PRight set on the sub-tree, so add +1 to get this node's PRight
		          //                          SET @Position = @Position + 1

		          //                          --@Depth gets decremented when you travel up from child to parent
		          //                          SET @Depth = @Depth - 1

		          //                          --Update this node's PRight as mentioned above
		          //                          ALTER TABLE Accounting.AccountingDataAccount DISABLE TRIGGER trg_AccountingDataAccount_UPD;

		          //                          UPDATE Accounting.AccountingDataAccount SET rgt = @Position
		          //                          WHERE NoUrutAccountId = @NoUrutAccountId

                //                              --  TRIGGER UPD SPT MENGGANGGU INPUTAN
		          //                         -- ALTER TABLE Accounting.AccountingDataAccount ENABLE TRIGGER trg_AccountingDataAccount_UPD;

		          //                          --continue looping
		          //                          FETCH NEXT FROM @Curff INTO @NoUrutAccountId
	           //                         END
	           //                         CLOSE @Curff
	           //                         DEALLOCATE @Curff

	           //                         RAISERROR('RebuildAccountTree for %d returning %d --at Depth=%d', 0, 1, @Parent, @Position, @Depth) WITH NOWAIT

	           //                         --Return PRight as set on this node, so that caller knows what it's new PRight should be
	           //                         RETURN @Position
            //                        END
            
            //");

            //migrationBuilder.Sql(@"

            //                           CREATE TRIGGER DataPerusahaan.trg_DataPerusahaanStrukturJabatan_INS
	           //                         ON DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                         AFTER INSERT
            //                        AS 
            //                        BEGIN
	           //                         SET NOCOUNT ON;

	           //                         --Cannot function on more than 1 inserted record at a time
	           //                         IF (SELECT COUNT(1) FROM Inserted) > 1
	           //                         BEGIN
		          //                          RAISERROR (N'This table does not support multiple inserts in one SQL statement', 18, 1)

		          //                          DELETE FROM DataPerusahaan.DataPerusahaanStrukturJabatan
		          //                          WHERE NoUrutStrukturID IN (SELECT NoUrutStrukturID FROM Inserted)

		          //                          RETURN
	           //                         END

	           //                         --If Root node, simply place at the end (right) of all other Roots (i.e. max-right)
	           //                         IF ((SELECT Parent FROM Inserted) IS NULL
		          //                          OR (SELECT Parent FROM Inserted) = -1) -- root node
	           //                         BEGIN
		          //                          DECLARE @Left INT	

		          //                          SELECT @Left = COALESCE(MAX(Rgt), 0) + 1
		          //                          FROM DataPerusahaan.DataPerusahaanStrukturJabatan
		
		          //                          UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan
		          //                          SET Lft = @Left, Rgt = @Left + 1, Depth = 0
		          //                          WHERE NoUrutStrukturID = (SELECT NoUrutStrukturID FROM Inserted)
	           //                         END
	           //                         --Else, shift ALL sub-trees over (right) by 2
	           //                         --& place the newly Inserted at the tail-end (right) of its siblings
	           //                         ELSE
	           //                         BEGIN
		          //                          DECLARE @ParentRight INT, @Depth INT

		          //                          SELECT @ParentRight = Rgt, @Depth = Depth + 1
		          //                          FROM DataPerusahaan.DataPerusahaanStrukturJabatan
		          //                          WHERE NoUrutStrukturID = (SELECT Parent FROM Inserted)

		          //                          --SHIFT EVERYTHING ELSE OVER (right) 2
		          //                          UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan
		          //                          SET Lft = CASE WHEN Lft > @ParentRight THEN Lft + 2 ELSE Lft END
		          //                            , Rgt = CASE WHEN Rgt >= @ParentRight THEN Rgt + 2 ELSE Rgt END
		          //                          WHERE Rgt >= @ParentRight

		          //                          --new record goes below (to the right of) its right-most sibling

            //                                UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan

            //                                SET Lft = @ParentRight, Rgt = @ParentRight + 1
            //                                  , Depth = @Depth

            //                                WHERE NoUrutStrukturID = (SELECT NoUrutStrukturID FROM Inserted)

            //                            END
            //                        END
                                    

            //             ");


            //migrationBuilder.Sql(@"

            //                  CREATE TRIGGER  DataPerusahaan.trg_DataPerusahaanStrukturJabatan_UPD
	           //                 ON DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 INSTEAD OF UPDATE
            //                AS 
            //                BEGIN
	           //                 SET NOCOUNT ON;

	           //                 --Don't allow updates to structural fields (Position, Depth) nor parent; really, you can only update Name.
	           //                 IF (EXISTS (SELECT 1
		          //                  FROM Deleted
		          //                  JOIN Inserted
			         //                   ON Inserted.NoUrutStrukturID = Deleted.NoUrutStrukturID
		          //                  WHERE Deleted.Parent <> Inserted.Parent
			         //                   OR Deleted.Lft <> Inserted.Lft
			         //                   OR Deleted.Rgt <> Inserted.Rgt
			         //                   OR Deleted.Depth <> Inserted.Depth
		          //                  ))
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot update position/parent values inline; use the dedicated stored-procedure to move nodes.', 18, 1)
		          //                  RETURN
	           //                 END

	           //                 --Don't allow updates to NULL values
	           //                 IF (EXISTS (SELECT 1
		          //                  FROM Deleted
		          //                  JOIN Inserted
			         //                   ON Inserted.NoUrutStrukturID = Deleted.NoUrutStrukturID
		          //                  WHERE Inserted.Parent IS NULL
			         //                   OR Inserted.Lft IS NULL
			         //                   OR Inserted.Rgt IS NULL
			         //                   OR Inserted.Depth IS NULL
		          //                  ))
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot update values to NULL; use the dedicated stored-procedure to set a node to root (NULL parent).', 18, 1)

            //                        RETURN

            //                    END

            //                    --Else, proceed with update-- you can only update the Name!
            //                    UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan SET DataPerusahaan.DataPerusahaanStrukturJabatan.NamaStrukturJabatan = Inserted.NamaStrukturJabatan

            //                    FROM DataPerusahaan.DataPerusahaanStrukturJabatan

            //                    JOIN Inserted

            //                        ON Inserted.NoUrutStrukturID = DataPerusahaan.DataPerusahaanStrukturJabatan.NoUrutStrukturID
            //                END
                            


            //    ");

            //migrationBuilder.Sql(@"

            //                        CREATE TRIGGER DataPerusahaan.trg_DataPerusahaanStrukturJabatan_DEL
	           //                         ON DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                         INSTEAD OF DELETE
            //                        AS 
            //                        BEGIN
	           //                         SET NOCOUNT ON;

	           //                         --Cannot function on more than 1 deleted record at a time
	           //                         IF (SELECT COUNT(1) FROM Deleted) > 1
	           //                         BEGIN
		          //                          RAISERROR (N'This table does not support multiple inserts in one SQL statement', 18, 1)
		          //                          RETURN
	           //                         END

	           //                         --Get properties of deleting node
	           //                         DECLARE @DelID INT, @DelParentID INT
		          //                          , @DelLeft INT, @DelRight INT
		          //                          , @DelDepth INT

	           //                         SELECT @DelID = NoUrutStrukturID , @DelParentID = Parent
		          //                          , @DelLeft = Lft, @DelRight = Rgt
		          //                          , @DelDepth = Depth
	           //                         FROM Deleted

	           //                         --Ready to delete the node
	           //                         DELETE FROM DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                         WHERE NoUrutStrukturID = @DelID

	           //                         --If furthest right root node, no need to move any others
	           //                         IF (@DelRight = (SELECT MAX(Rgt) FROM DataPerusahaan.DataPerusahaanStrukturJabatan))
		          //                          RETURN;

	           //                         --Else, we have to shift nodes left & promote children
	           //                         ELSE
	           //                         BEGIN
		          //                          --shift everything left 2
		          //                          UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan
		          //                          SET Lft = (CASE WHEN Lft > @DelRight THEN Lft - 2 ELSE Lft END)
		          //                            , Rgt = (CASE WHEN Rgt >= @DelRight THEN Rgt - 2 ELSE Rgt END)
		          //                          WHERE Rgt >= @DelRight

		          //                          --If leaf node, no need to move children.
		          //                          --Else, shift nodes back (left) by 2, if they are above / right of the deleted node;
            //                                --then we need to promote children to next level up(or they'll be orphans!)
            //                                --Children will be placed in deleted node's space, i.e. squeezed between its old neighbors.

            //                                IF(EXISTS(SELECT 1

            //                                            FROM DataPerusahaan.DataPerusahaanStrukturJabatan child

            //                                            WHERE child.Parent = @DelID))

            //                                BEGIN
            //                                    --set childrens' ParentID to old Parent, up Depth by 1, & subtract 1 from Positions

            //                                    UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan

            //                                    SET Parent = @DelParentID, Depth = @DelDepth
            //                                        , Lft = Lft - 1, Rgt = Rgt - 1

            //                                    WHERE Parent = @DelID

            //                                END

            //                            END
            //                        END
                                  

            //");

            //migrationBuilder.Sql(@"

            
            //                CREATE PROCEDURE [dbo].[MoveStrukturJabatanSubtree]
	           //                 @NoUrutStrukturID INT
	           //                 , @NewParent INT
	           //                 , @Debug BIT = 0
            //                AS
            //                BEGIN
	           //                 SET NOCOUNT ON;

	           //                 --Disable triggers during operations
	           //                 ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan DISABLE TRIGGER trg_DataPerusahaanStrukturJabatan_DEL;
	           //                 ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan DISABLE TRIGGER trg_DataPerusahaanStrukturJabatan_INS;
	           //                 ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan DISABLE TRIGGER trg_DataPerusahaanStrukturJabatan_UPD;

	           //                 --Treat 0/-1/NULL the same: means we want to make the top of this subtree a Root node
	           //                 IF (@NewParent <= 0 OR @NewParent IS NULL)
	           //                 BEGIN
		          //                  SET @NewParent = -1;
	           //                 END

	           //                 --Cannot move a subtree under itself
	           //                 ELSE IF @NewParent IN (
		          //                  SELECT SubCat.NoUrutStrukturID
		          //                  FROM DataPerusahaan.DataPerusahaanStrukturJabatan Cat
		          //                  JOIN DataPerusahaan.DataPerusahaanStrukturJabatan SubCat
				        //                    ON SubCat.Lft BETWEEN Cat.Lft AND Cat.Rgt
		          //                  WHERE Cat.NoUrutStrukturID = @NoUrutStrukturID)
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot move subtree to a node within itself.', 18, 1);
		          //                  RETURN;
	           //                 END

	           //                 --Cannot move subtree to a node that doesnt exist
	           //                 ELSE IF NOT EXISTS (SELECT 1 FROM DataPerusahaan.DataPerusahaanStrukturJabatan WHERE NoUrutStrukturID = @NewParent)
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot move subtree to a node that doesn''t exist.', 18, 1);
		          //                  RETURN;
	           //                 END

	           //                 --Cannot move subtree that doesnt exist
	           //                 ELSE IF NOT EXISTS (SELECT 1 FROM DataPerusahaan.DataPerusahaanStrukturJabatan WHERE NoUrutStrukturID = @NoUrutStrukturID)
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot move subtree that doesn''t exist.', 18, 1);
		          //                  RETURN;
	           //                 END

	           //                 --Get old Parent & Subtree size
	           //                 DECLARE @OldParent INT
		          //                  , @SubtreeSize INT
		          //                  , @SubtreeOldLeft INT
		          //                  , @SubtreeOldRight INT
		          //                  , @SubtreeOldDepth INT

	           //                 SELECT @OldParent = Parent,  @SubtreeSize = Rgt - Lft + 1
		          //                  , @SubtreeOldLeft = Lft, @SubtreeOldRight = Rgt, @SubtreeOldDepth = Depth
	           //                 FROM DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 WHERE NoUrutStrukturID = @NoUrutStrukturID

	           //                 --Cannot move subtree to its own Parent, i.e. there's nothing to do b/c new parent is same as old
	           //                 IF @OldParent = @NewParent
	           //                 BEGIN
		          //                  RAISERROR (N'Cannot move subtree to its own parent.', 18, 1);
		          //                  RETURN;
	           //                 END

	           //                 --Get new Parent position
	           //                 DECLARE @NewParentRight INT
		          //                  , @NewParentDepth INT;

	           //                 --If we're going Root, place it to the Right of existing Roots
	           //                 IF @NewParent = -1
	           //                 BEGIN
		          //                  SELECT @NewParentRight = MAX(Rgt) + 1, @NewParentDepth = -1
		          //                  FROM DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 END
	           //                 --Else, place it to the Right of its new siblings-to-be
	           //                 ELSE
	           //                 BEGIN
		          //                  SELECT @NewParentRight = Rgt, @NewParentDepth = Depth
		          //                  FROM DataPerusahaan.DataPerusahaanStrukturJabatan
		          //                  WHERE NoUrutStrukturID = @NewParent
	           //                 END

	           //                 --Get new positions for use
	           //                 SELECT NoUrutStrukturID
		          //                  , Lft + @NewParentRight - @SubtreeOldLeft AS PLeft
		          //                  , Rgt + @NewParentRight - @SubtreeOldLeft AS PRight
		          //                  , Depth + (@NewParentDepth - @SubtreeOldDepth) + 1 AS Depth
	           //                 INTO #MoveNodes
	           //                 FROM DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 WHERE NoUrutStrukturID IN (
		          //                  SELECT SubCat.NoUrutStrukturID
		          //                  FROM DataPerusahaan.DataPerusahaanStrukturJabatan Cat
		          //                  JOIN DataPerusahaan.DataPerusahaanStrukturJabatan SubCat
				        //                    ON SubCat.Lft BETWEEN Cat.Lft AND Cat.Rgt
		          //                  WHERE Cat.NoUrutStrukturID = @NoUrutStrukturID
	           //                 )

	           //                 IF (@Debug = 1)
		          //                  SELECT * FROM #MoveNodes
		          //                  ORDER BY PLeft

	           //                 --Make gap in tree (at destination branch) equal to the SubtreeSize
	           //                 UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 SET Lft = CASE WHEN Lft > @NewParentRight THEN Lft + @SubtreeSize ELSE Lft END,
		          //                  Rgt = CASE WHEN Rgt >= @NewParentRight THEN Rgt + @SubtreeSize ELSE Rgt END
	           //                 WHERE Rgt >= @NewParentRight

	           //                 --Update Subtree positions to new ones
	           //                 UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 SET Lft = #MoveNodes.PLeft, Rgt = #MoveNodes.PRight, Depth = #MoveNodes.Depth
	           //                 FROM DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 JOIN #MoveNodes
			         //                   ON DataPerusahaan.DataPerusahaanStrukturJabatan.NoUrutStrukturID = #MoveNodes.NoUrutStrukturID

	           //                 --Maintain the Adjacency-List part (set ParentID)
	           //                 UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 SET Parent = (CASE WHEN @NewParent = -1 THEN NULL ELSE @NewParent END)
	           //                 WHERE NoUrutStrukturID = @NoUrutStrukturID

	           //                 --Close gaps, i.e. after the Subtree is gone from its old Parent, said old parent node has no children;
	           //                 --while nodes to the right & above now have inflated values, except where they include the newly moved subtree.
	           //                 UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan
	           //                 SET Lft = CASE WHEN Lft > @SubtreeOldRight THEN Lft - @SubtreeSize ELSE Lft END,
		          //                  Rgt = CASE WHEN Rgt >= @SubtreeOldRight THEN Rgt - @SubtreeSize ELSE Rgt END
	           //                 WHERE Rgt >= @SubtreeOldRight

	           //                 --Re-enable triggers when done
	           //                 ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan ENABLE TRIGGER trg_DataPerusahaanStrukturJabatan_DEL;
	           //                 ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan ENABLE TRIGGER trg_DataPerusahaanStrukturJabatan_INS;
	           //                 ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan ENABLE TRIGGER trg_DataPerusahaanStrukturJabatan_UPD;
            //                END
                             

            
            //    ");

            //migrationBuilder.Sql(@"

            //    CREATE PROCEDURE [dbo].[RebuildStrukturJabatanTree]
	           //                         @Parent INT = NULL
	           //                         , @Position INT = 0
	           //                         , @Depth INT = 0
            //                        AS
            //                        BEGIN
	           //                         SET NOCOUNT ON;
	
	           //                         --Starting depth; we will set this to the given Parent's Depth (or 0 if NULL)
	           //                         --DECLARE @Depth INT
	           //                         /*
	           //                         SELECT @Depth = (CASE WHEN @ParentID IS NULL THEN 0 ELSE Depth END)
		          //                          FROM nsm.Cat
		          //                          WHERE (@ParentID IS NULL AND ParentID IS NULL)
			         //                           OR ParentID = @ParentID
	           //                         */

	           //                         --Cursor (loop) over child nodes of the given ParentID
	           //                         DECLARE @Curff CURSOR 
	           //                         SET @Curff = CURSOR READ_ONLY FAST_FORWARD FOR
		          //                          SELECT NoUrutStrukturID
		          //                          FROM DataPerusahaan.DataPerusahaanStrukturJabatan
		          //                          WHERE (@Parent IS NULL AND Parent IS NULL)
			         //                           OR Parent = @Parent
		          //                          ORDER BY Lft

	           //                         DECLARE @NoUrutStrukturID INT
	           //                         OPEN @Curff
	           //                         FETCH NEXT FROM @Curff INTO @NoUrutStrukturID

	           //                         WHILE @@FETCH_STATUS = 0
	           //                         BEGIN
		          //                          --Assumption: @Position starts at the CORRECT # from the given parent
		          //                          SET @Position = @Position + 1

		          //                          --@Depth gets incremented when you travel down from parent to child
		          //                          SET @Depth = @Depth + 1

		          //                          --Update this node's PLeft & Depth
		          //                          ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan DISABLE TRIGGER trg_DataPerusahaanStrukturJabatan_UPD;

		          //                          UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan SET Lft = @Position, Depth = @Depth
		          //                          WHERE NoUrutStrukturID = @NoUrutStrukturID

		          //                          ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan ENABLE TRIGGER trg_DataPerusahaanStrukturJabatan_UPD;

		          //                          --Recursively re-number this node's children
		          //                          RAISERROR ('Calling RebuildAccountTree %d, %d --at Depth=%d', 0, 1, @NoUrutStrukturID, @Position, @Depth) WITH NOWAIT
		
		          //                          EXEC @Position = RebuildStrukturJabatanTree @NoUrutStrukturID, @Position, @Depth

		          //                          --It returns the last PRight set on the sub-tree, so add +1 to get this node's PRight
		          //                          SET @Position = @Position + 1

		          //                          --@Depth gets decremented when you travel up from child to parent
		          //                          SET @Depth = @Depth - 1

		          //                          --Update this node's PRight as mentioned above
		          //                          ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan DISABLE TRIGGER trg_DataPerusahaanStrukturJabatan_UPD;

		          //                          UPDATE DataPerusahaan.DataPerusahaanStrukturJabatan SET rgt = @Position
		          //                          WHERE NoUrutStrukturID = @NoUrutStrukturID

                //                             -- TRIGGER UPD SPTNYA MENGGANGGU INPUTAN
		          //                         -- ALTER TABLE DataPerusahaan.DataPerusahaanStrukturJabatan ENABLE TRIGGER trg_DataPerusahaanStrukturJabatan_UPD;

		          //                          --continue looping
		          //                          FETCH NEXT FROM @Curff INTO @NoUrutStrukturID
	           //                         END
	           //                         CLOSE @Curff
	           //                         DEALLOCATE @Curff

	           //                         RAISERROR('RebuildStrukturJabatanTree for %d returning %d --at Depth=%d', 0, 1, @Parent, @Position, @Depth) WITH NOWAIT

	           //                         --Return PRight as set on this node, so that caller knows what it's new PRight should be
	           //                         RETURN @Position
            //                        END
            
            

            //");




        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("DROP TRIGGER IF EXISTS Accounting.trg_AccountingDataAccount_INS");
            //migrationBuilder.Sql("DROP TRIGGER IF EXISTS Accounting.trg_AccountingDataAccount_DEL");
            //migrationBuilder.Sql("DROP TRIGGER IF EXISTS Accounting.trg_AccountingDataAccount_UPD");
            //migrationBuilder.Sql("DROP PROCEDURE IF EXISTS MoveAccountSubtree");
            //migrationBuilder.Sql("DROP PROCEDURE IF EXISTS RebuildAccountTree");
            //migrationBuilder.Sql("DROP TRIGGER IF EXISTS DataPerusahaan.trg_DataPerusahaanStrukturJabatan_INS");
            //migrationBuilder.Sql("DROP TRIGGER IF EXISTS DataPerusahaan.trg_DataPerusahaanStrukturJabatan_DEL");
            //migrationBuilder.Sql("DROP TRIGGER IF EXISTS DataPerusahaan.trg_DataPerusahaanStrukturJabatan_UPD");
            //migrationBuilder.Sql("DROP PROCEDURE IF EXISTS MoveStrukturJabatanSubtree");
            //migrationBuilder.Sql("DROP PROCEDURE IF EXISTS RebuildStrukturJabatanTree");
        }
    }
}
