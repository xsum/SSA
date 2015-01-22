select TeacherName,TrainingCenterName=stuff
(    
	(select ','+TrainingCenterName
	from @tmp a where a.TeacherName=b.TeacherName for xml path('')
	),1,1,''
)
from @tmp b
group by TeacherName