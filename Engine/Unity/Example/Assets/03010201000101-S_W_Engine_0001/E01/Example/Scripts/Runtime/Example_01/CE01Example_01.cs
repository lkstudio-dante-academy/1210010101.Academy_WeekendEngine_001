using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 컴포넌트란?
 * - 특정 기능을 수행하는 하나의 단위를 의미한다. 따라서, 컴포넌트를 조합해서 특정 역할을 하는 대상을 표현하는 것이 가능하다.
 * (즉, Unity 는 컴포넌트를 기반으로 특정 목적을 달성 할 수 있는 프로그램을 제작하며 이러한 방식을 컴포넌트 기반 프로그래밍
 * 방식이라고 한다.)
 * 
 * 객체 지향 프로그래밍 vs 컴포넌트 기반 프로그래밍
 * - 객체 지향 프로그래밍 특정 역할을 수행하는 대상을 먼저 정의한 후에 해당 대상에 기능을 확장 시켜나가는 반면, 컴포넌트 기반
 * 프로그래밍은 컴포넌트를 조합함으로써 특정 대상을 정의하는 차이점이 존재한다. (즉, 둘 다 프로그램의 구조를 설계하는 방법이지만
 * 해당 프로그램 구조를 이를 대상을 어떤 시선으로 바라보는지에 대한 차이점이 존재한다.)
 * 
 * 따라서, Unity 는 게임 객체와 더불어 여러 컴포넌트를 제공하며 여러 컴포넌트를 게임 객체에 추가함으로서 특정 대상을 표현하는
 * 것이 가능하다. (즉, 게임 객체는 단순히 컴포넌트를 담기위한 그릇에 불가하다는 것을 알 수 있다.)
 * 
 * 단, Unity 가 제공해주는 컴포넌트만으로는 다양한 목적에 맞는 프로그램을 제작하는 것이 불가능하기 때문에 Unity 는 사용자가 직접
 * 구현 할 수 있는 컴포넌트를 제공하며 이를 스크립트 컴포넌트라고 한다. (즉, 스크립트 컴포넌트를 활용하면 특정 목적에 맞는 기능
 * 을 커스텀하게 구현하는 것이 가능하다.)
 * 
 * 스크립트 컴포넌트 구현 조건
 * - MonoBehaviour 클래스를 직/간접적으로 상속해야한다.
 * - 클래스 이름과 해당 스크립트 파일 이름이 서로 동일해야한다.
 * 
 * 즉, 클래스 이름과 스크립트 파일 이름이 서로 다를 경우에는 해당 스크립트를 게임 객체에 추가하는 것은 불가능하다. 단, 해당
 * 스크립트를 게임 객체에 직접적으로 추가하는 것이 불가능하지만 내부적으로 해당 클래스를 통해서 특정 구문을 작성하는데는 전혀
 * 지장이 없다. 
 * 
 * 따라서, 게임 객체에 직접적으로 추가하고 싶은 클래스만 컴포넌트가 되기 위한 조건을 만족시키면 된다.
 */
/** Example 1 */
public class CE01Example_01 : CSceneManager
{
	#region 프로퍼티
	public override string SceneName => KDefine.G_SCENE_N_E01;
	#endregion // 프로퍼티

	#region 함수
	/** 초기화 */
	public override void Awake()
	{
		base.Awake();
		Debug.Log("Hello, World!");
	}
	#endregion // 함수
}
