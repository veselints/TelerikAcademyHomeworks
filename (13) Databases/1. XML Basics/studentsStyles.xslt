<?xml version="1.0" encoding="utf-8"?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" > 
<xsl:template match="/"> 
<html> 
         <style> 
           dl {
           margin: 0;
           padding: 0;
           }
           dt {
           font-weight: bold;
           }
           #exams { 
           width: 50%; 
           font-size: 0.9em;
           border-bottom: 1px solid #F00 
           }
           dd { 
           color: #FA0; 
           padding-top: 0px; 
           padding-bottom: 0px; 
           }
           dt {
           padding-top: 10px;
           padding-bottom: 0;
           }
           dd dt {
           color: black;
           }
         </style> 
         <body> 
           <h2>Students: </h2> 
           <div> 
             <xsl:for-each select="students/student"> 
               <dl> 
                 <dt> 
                   Name of Student: 
                 </dt> 
                 <dd> 
                   <xsl:value-of select="name"/> 
                 </dd> 
                 <dt> 
                   Gender: 
                 </dt> 
                 <dd> 
                   <xsl:value-of select="sex"/> 
                 </dd> 
                 <dt> 
                   Date of Birth: 
                 </dt> 
                 <dd> 
                   <xsl:value-of select="birth_date"/> 
                 </dd> 
                 <dt> 
                   Phone Number: 
                 </dt> 
                 <dd> 
                   <xsl:value-of select="phone"/> 
                 </dd> 
                 <dt> 
                   Email: 
                 </dt> 
                 <dd> 
                   <xsl:value-of select="email"/> 
                 </dd> 
                 <dt> 
                   Current Course: 
                 </dt> 
                 <dd> 
                   <xsl:value-of select="course"/> 
                 </dd> 
                 <dt> 
                   Specialty: 
                 </dt> 
                 <dd> 
                   <xsl:value-of select="specialty"/> 
                </dd> 
                 <dt> 
                  Faculty Number: 
                 </dt> 
                 <dd> 
                   <xsl:value-of select="faculty_number"/> 
                </dd> 
                <dt> 
                 Taken Exams: 
                </dt> 
               <dd id="exams"> 
                <dl> 
              	<xsl:for-each select="taken_exams/exam"> 
                  <dt>Exam name: </dt> 
                   <dd> 
                         <xsl:value-of select="exam_name"/> 
                 </dd> 
                  <dt>Tutor: </dt> 
                   <dd> 
                    <xsl:value-of select="tutor"/> 
                  </dd> 
                    <dt>Score: </dt> 
                    <dd> 
                         <xsl:value-of select="score"/> 
                       </dd> 
                     </xsl:for-each> 
                   </dl> 
                 </dd> 
               </dl> 
             </xsl:for-each> 
           </div> 
           <!-- <h3>Enrollment Days:</h3> 
           <div> 
             <xsl:for-each select="enrollment/dates/date"> 
               <p><xsl:value-of select="day"/></p> 
             </xsl:for-each> 
             <p>Minimal GPA: <xsl:value-of select="enrollment/gpa"/></p> 
           </div> 
           <h3>Teacher Certifications:</h3> 
           <div> 
             <xsl:for-each select="teachers/teacher"> 
               <p>~~ <xsl:value-of select="name"/> ~~ - <xsl:value-of select="certification" /></p> 
             </xsl:for-each> 
           </div>  -->
         </body> 
       </html> 
     </xsl:template> 
 </xsl:stylesheet> 
