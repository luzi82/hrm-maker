using System;

public enum InstructionType
{
	Inbox,
	Outbox,
	CopyFrom,
	CopyTo,
	Add,
	Sub,
	BumpUp,
	BumpDown,
	Jump,
	JumpZ,
	JumpN,
	Comment
}

public class InstructionTypeConst{
	static public int INSTRUCTION_TYPE_LENGTH = System.Enum.GetValues (typeof(InstructionType)).Length;
}
