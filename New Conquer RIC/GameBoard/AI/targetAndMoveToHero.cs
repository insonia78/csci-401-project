using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Collections;
using Community;

namespace GameBoard
{
    public partial class MainWindow : Page
    {

        int aheroRow, aheroCol;
        int aindex = 0;
        int iterationNumber = 0;
         int i = 0;
        public void targetAndMoveToHero()
        {
            int row = 0;
            int col = 0;
            int done = 0;
            int index = 0;
            int targetEnemyCount = 0;
            int targetHeroCount = 0;
            iterationNumber = 0;
            double dummyTemp = 0;
            int dummyIndex = 0;
            
            ArrayList selectHeroHealt = new ArrayList();
            ArrayList selectEnemyAttack = new ArrayList();
            ArrayList selectEnemyHealt = new ArrayList();
            ArrayList selectHeroAttack = new ArrayList();
            ArrayList dummyTargetHeroAttack = new ArrayList();
            ArrayList dummyTargetHeroHealth = new ArrayList();
            ArrayList dummyTargetEnemyAttack = new ArrayList();
            ArrayList dummyTargetEnemyHealth = new ArrayList();
            ArrayList heroHealthEnemyAttachWeight = new ArrayList();
            ArrayList targetHeroRow1 = new ArrayList();
            ArrayList targetHeroCol1 = new ArrayList();
            ArrayList targetEnemyRow1 = new ArrayList();
            ArrayList targetEnemyCol1 = new ArrayList();
          /* 
            int tempEnemyAttack = (int)targetEnemyAttack[0];
            while (done < targetEnemyAttack.Count)
            {
                dummyTargetEnemyAttack.Add((int)targetEnemyAttack[done]);
                dummyTargetEnemyHealth.Add((int)targetEnemyHealth[done]);
                done++;
            }
            done = 0;
            while (done < targetHeroAttack.Count)
            {
                dummyTargetHeroAttack.Add((int)targetHeroAttack[done]);
                dummyTargetHeroHealth.Add((int)targetHeroHealth[done]);
                done++;
            }
            done = 0;
            Hero skip = new Hero();
            while (targetEnemyCount < targetEnemyAttack.Count)
            {
                while (done < dummyTargetEnemyAttack.Count)
                {
                    if (dummyTargetEnemyAttack[done].Equals(skip))
                    {
                    }
                    else
                    {
                        if (tempEnemyAttack > (int)dummyTargetEnemyAttack[done])
                        {
                            tempEnemyAttack = (int)dummyTargetEnemyAttack[done];
                            index = done;
                            done = 0;
                        }
                        
                    }
                    done++;

                }
                targetEnemyCount++;
                selectEnemyAttack.Add(index);
                
                dummyTargetEnemyAttack.RemoveAt(index);
                dummyTargetEnemyAttack.Insert(index, skip);
                int check = 0;
                if (dummyTargetEnemyAttack[check].Equals(skip))
                {
                    while (dummyTargetEnemyAttack[check].Equals(skip))
                    {
                        
                        check++;
                    }
                    tempEnemyAttack = (int)dummyTargetEnemyAttack[check];
                }
               
                index = 0;
                done = 0;
            }
            targetEnemyCount = 0;
           int tempHeroHealth = (int)targetHeroHealth[0];
            done = 0;
            while (targetEnemyCount < dummyTargetHeroHealth.Count)
            {
                while (done < dummyTargetHeroHealth.Count)
                {
                    if (dummyTargetHeroHealth[done].Equals(skip))
                    {
                    }
                    else
                    {
                        if (tempHeroHealth > (int)dummyTargetHeroHealth[done])
                        {
                            tempHeroHealth = (int)dummyTargetHeroHealth[done];
                            index = done;
                            done = 0;
                        }
                        
                    }
                    done++;
                    
                }
                targetEnemyCount++;
                selectHeroHealt.Add(index);
                
                dummyTargetHeroHealth.RemoveAt(index);
                dummyTargetHeroHealth.Insert(index, skip);
                int check = 0;
                if (dummyTargetHeroHealth[check].Equals(skip))
                {
                    while (dummyTargetHeroHealth[check].Equals(skip))
                    {
                        
                        check++;
                    }
                    tempHeroHealth = (int)dummyTargetHeroHealth[check];
                }
                index = 0;
                done = 0;
            }
            done = 0;
            targetEnemyCount = 0;
            int tempEnemyHealth = (int)targetEnemyHealth[0];
            while (targetEnemyCount < dummyTargetEnemyHealth.Count)
            {
                while (done < dummyTargetEnemyHealth.Count)
                {
                    if (dummyTargetEnemyHealth[done].Equals(skip))
                    {
                    }
                    else
                    {
                        if (tempEnemyAttack < (int)dummyTargetEnemyHealth[done])
                        {
                            tempEnemyAttack = (int)dummyTargetEnemyHealth[done];
                            index = done;
                            done = 0;
                        }
                        
                    }
                    done++;

                }
                targetEnemyCount++;
                selectEnemyHealt.Add(index + targetEnemyCount);
              
                dummyTargetEnemyHealth.RemoveAt(index);
                dummyTargetEnemyHealth.Insert(index, skip);
                int check = 0;
                if (dummyTargetEnemyHealth[check].Equals(skip))
                {
                    while (dummyTargetEnemyHealth[check].Equals(skip))
                    {
                       
                        check++;
                    }
                    tempHeroHealth = (int)dummyTargetEnemyHealth[check];
                }
                index = 0;
                done = 0;
            }
            targetEnemyCount = 0;
            int tempHeroAttack = (int)targetHeroAttack[0];
            done = 0;
            while (targetEnemyCount < dummyTargetHeroAttack.Count)
            {
                while (done < dummyTargetHeroAttack.Count)
                {
                    if (dummyTargetHeroAttack[done].Equals(skip))
                    {
                    }
                    else
                    {
                        if (tempHeroHealth > (int)dummyTargetHeroAttack[done])
                        {
                            tempHeroHealth = (int)dummyTargetHeroAttack[done];
                            index = done;
                            done = 0;
                        }
                        
                    }
                      done++;

                }
                targetEnemyCount++;
                selectHeroAttack.Add(index + targetEnemyCount);
              
                dummyTargetHeroAttack.RemoveAt(index);
                dummyTargetHeroAttack.Insert(index, skip);
                int check = 0;
                if (dummyTargetHeroAttack[check].Equals(skip))
                {
                    while (dummyTargetHeroAttack[check].Equals(skip))
                    {
                        
                        check++;
                    }
                    tempHeroHealth = (int)dummyTargetHeroAttack[check];
                }
                index = 0;
                done = 0;

            }*/
            done = 0;
            // to consider if enemy < hero or hero < enemy
            while (done < targetEnemyRow.Count)
            {
                int Erow = Math.Abs((int)targetEnemyRow[done] - (int)targetHeroRow[done]);
                int Ecol = Math.Abs((int)targetEnemyCol[done] - (int)targetHeroCol[done]);
                int Hrow = Math.Abs((int)targetEnemyRow[done] - (int)targetHeroRow[done]);
                int Hcol = Math.Abs((int)targetEnemyCol[done] - (int)targetHeroCol[done]);
                
               heroHealthEnemyAttachWeight.Add( (0.35 * (Hrow + Hcol) )+ (0.75 * (Erow + Ecol)));
               targetEnemyRow1.Add((int)targetEnemyRow[done]);
               targetEnemyCol1.Add((int)targetEnemyCol[done]);
               targetHeroRow1.Add((int)targetHeroRow[done]);
               targetHeroCol1.Add((int)targetHeroCol[done]);
               done++;
            }
            done = 0;
            try
            {
                dummyTemp = (double)heroHealthEnemyAttachWeight[0];
                dummyIndex = 0;
                while (done < heroHealthEnemyAttachWeight.Count)
                {
                    if (dummyTemp > (double)heroHealthEnemyAttachWeight[done])
                    {
                        dummyIndex = done;
                        dummyTemp = (double)heroHealthEnemyAttachWeight[done];
                        done = 0;
                    }
                    done++;


                }
            }
            catch
            {
                ok = false;
                Enemytimer.Stop();
                Enemytimer.Tick -= Etimer_Tick;
            }
                      

            if (targetEnemyRow.Count > 0 && countEnemiesForloop > 0)
            {
                try
                {
                    aheroRow = (int)targetHeroRow1[dummyIndex];
                    aheroCol = (int)targetHeroCol1[dummyIndex];

                }
                catch
                {
                }

                try
                {
                    
                    selectedCharacterRow = (int)targetEnemyRow1[dummyIndex];
                    selectedCharacterCol = (int)targetEnemyCol1[dummyIndex];
                }
                catch
                {
                }
                try
                {
                    targetEnemyRow.RemoveAt(dummyIndex);
                    targetEnemyCol.RemoveAt(dummyIndex);
                    targetEnemyAttack.RemoveAt(dummyIndex);
                    targetEnemyHealth.RemoveAt(dummyIndex);
                    
                    
                    selectHeroHealt.Clear();
                    selectEnemyAttack.Clear();
                    selectEnemyHealt.Clear();
                    selectHeroAttack.Clear();
                    dummyTargetHeroAttack.Clear();
                    dummyTargetHeroHealth.Clear();
                    dummyTargetEnemyAttack.Clear();
                    dummyTargetEnemyHealth.Clear();
                    heroHealthEnemyAttachWeight.Clear();
                    targetHeroRow1.Clear();
                    targetHeroCol1.Clear();
                    targetEnemyRow1.Clear();
                    targetEnemyCol1.Clear();
                }
                catch
                {
                    nextTurn();
                }
                // i++;

            }
            else
            {
                ok = false;
                Enemytimer.Stop();
                Enemytimer.Tick -= Etimer_Tick;
                

            }
                
                //EnemyAbility1();
                //displayEnemyAttackAreas();
            }
        
        
         
        }
    }

